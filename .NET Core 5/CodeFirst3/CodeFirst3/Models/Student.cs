﻿using CodeFirst3.Enums;
using System;
using System.Collections.Generic;

namespace CodeFirst3.Models
{
    public class Student:BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        

        public Gender Gender { get; set; }

      

       

        public  List<Operation> Operations { get; set; }

        public virtual StudentDetail StudentDetail { get; set; }
    }
}
