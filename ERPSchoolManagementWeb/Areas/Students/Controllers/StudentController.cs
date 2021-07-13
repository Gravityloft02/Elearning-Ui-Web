using ERPSchoolManagementWeb.Interfaces;
using ERPSchoolManagementWeb.Models;
using ERPSchoolManagementWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace ERPSchoolManagementWeb.Areas.Students.Controllers
{
    public class StudentController : Controller
    {
        IManagement _service;
        ILocation _location;
        public StudentController()
        {
            _service = new ManagementService();
            _location = new LocationService();
        }
        // GET: Management/Teachers
        public async Task<ActionResult> Index()
        {
            //var user = ERPSchoolManagementWeb.Helper.SessionHelper.Instance.User;
            var res = await _service.GetAllStudents();
            var result = res.OrderByDescending(x => x.Sno);
            return View(result);
        }

        [HttpGet]
        public async Task<ActionResult> New()
        {
            return View(new CustomStudentModel());
        }

        [HttpPost]
        public async Task<JsonResult> AddStudent(CustomStudentModel student)
        {
            ///student.ParentId = 1;
            var res = await _service.AddStudent(student);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}