﻿namespace CodeFirst.Models
{
    public class AppUserDetail: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        
        public int AppUserID { get; set; } // foreign key

        // relational property one to one
        public AppUser AppUser { get; set; }
    }
}
