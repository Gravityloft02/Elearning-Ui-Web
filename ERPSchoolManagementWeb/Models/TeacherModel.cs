﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPSchoolManagementWeb.Models
{
    public class TeacherModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? CreatedDate { get; set; } 
    }
}