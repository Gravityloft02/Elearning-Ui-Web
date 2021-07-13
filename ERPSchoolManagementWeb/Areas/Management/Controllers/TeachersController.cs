using ERPSchoolManagementWeb.Interfaces;
using ERPSchoolManagementWeb.Models;
using ERPSchoolManagementWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ERPSchoolManagementWeb.Areas.Management.Controllers
{
    public class TeachersController : Controller
    {
        IManagement _service;
        ILocation _location;
        public TeachersController()
        {
            _service = new ManagementService();
            _location = new LocationService();
        }
        // GET: Management/Teachers
        public async Task<ActionResult> Index()
        {
            //var user = ERPSchoolManagementWeb.Helper.SessionHelper.Instance.User;
            var res = await _service.GetAllTeachers();
            var result = res.OrderByDescending(x => x.Id);
            return View(result);
        }

        [HttpGet]
        public async Task<ActionResult> New()
        {
            return View(new TeacherModel());
        }

        [HttpPost]
        public async Task<JsonResult> AddTeacher(TeacherModel teacher)
        {
            var res = await _service.AddTeacher(teacher);
            return Json(res, JsonRequestBehavior.AllowGet);
        }

    }
}