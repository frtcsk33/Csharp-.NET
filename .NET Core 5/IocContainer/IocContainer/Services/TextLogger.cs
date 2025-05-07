using IocContainer.Services.Interfaces;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocContainer.Services
{
    public class TextLogger: ILog
    {
        private bool ex;

        public TextLogger(IHostEnvironment env)
        {
            try
            {
                string date = DateTime.Now.ToString("d-m-yyyy");
                 path = $"{env.ContentRootPath}/Logs/{date}.txt";

                if (!File.Exists(path))
                {
                    using (File.Create(path))
                    {};
                }
            }
            catch (Exception)
            {

                Console.WriteLine(ex.Message);
            }
          
        }
        string path;
        public void Info(string message)
        {

            try
            {
                using (StreamWriter stream = new StreamWriter(path,true,Encoding.UTF8))
                {
                string time = DateTime.Now.ToString("HH:mm");
                stream.WriteLine($"##INFO## &&{time}&& || message: {message}");
                };
            }
            catch (Exception)
            {

                throw;
            }

           
        }

        public void info(string message)
        {
            throw new NotImplementedException();
        }
    }
}
