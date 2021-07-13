using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPSchoolManagementWeb.Models
{
    public class SubjectModel
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }
        public int? GradeId { get; set; }
    }
}