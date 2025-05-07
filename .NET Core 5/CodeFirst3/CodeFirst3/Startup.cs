using CodeFirst3.Context;
using CodeFirst3.Models;
using CodeFirst3.RepositoryPattern.Base;
using CodeFirst3.RepositoryPattern.Concrete;
using CodeFirst3.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst3
{
    public class Startup
    {
        readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(_configuration["ConnectionStrings:Mssql"]));
            services.AddControllersWithViews();
            services.AddScoped<IRepository<BookType>, Repository<BookType>>();
            services.AddScoped<IRepository<AppUser>, Repository<AppUser>>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookTypeRepository, BookTypeRepository>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {

                options.LoginPath = "/Auth/Login";
                options.Cookie.Name = "UserDetail";
                options.AccessDeniedPath = "/Auth/Login";
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminPolicy",policy => policy.RequireClaim("role","admin"));

                options.AddPolicy("UserPolicy", policy => policy.RequireClaim("role", "admin", "user"));

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //context.Database.Migrate();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();         app.UseStaticFiles();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "DefaultArea",
                        pattern: "{area=exists}/{controller=Home}/{action=Index}/{id?}");


                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Auth}/{action=Login}/{id?}"
                    );

            });
        }
    }
}
