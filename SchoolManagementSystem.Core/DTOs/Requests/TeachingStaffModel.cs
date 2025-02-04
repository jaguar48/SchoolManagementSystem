﻿using System;
using SchoolManagementSystem.Core.Entities;

namespace SchoolManagementSystem.Core.DTOs.Requests
{
    public class TeachingStaffModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string LGA { get; set; }
        public string StateOfOrigin { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImageUrl { get; set; }


        
    }
}

