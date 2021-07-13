using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPSchoolManagementWeb.Models.Request
{
    public class ElearningLoginModel
    {
        public string LoginId { get; set; }
        public string Password { get; set; }
        public string SchoolCode { get; set; }
        public string YearSession { get; set; }
        public int RoleId { get; set; }
    }
}