﻿namespace CodeFirst3.Dto
{
    public class AuthorDto
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }


    }
}
