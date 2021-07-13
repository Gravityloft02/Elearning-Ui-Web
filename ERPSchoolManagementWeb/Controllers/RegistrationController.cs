using ERPSchoolManagementWeb.Interfaces;
using ERPSchoolManagementWeb.Models;
using ERPSchoolManagementWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using ERPSchoolManagementWeb.Models.Request;

namespace ERPSchoolManagementWeb.Controllers
{
    public class RegistrationController : Controller
    {
        IManagement _service;
        ILocation _location;
        public RegistrationController()
        {
            _service = new ManagementService();
            _location = new LocationService();
        }
        // GET: Registration
        public async Task<ActionResult> Index()
        {
            var rl = await _service.GetRoleList();
            ViewData["Roles"] = new SelectList(rl, "Id", "RoleName");
            return View(new UserRegistrationRequest());
        }

        [HttpPost]
        public async Task<JsonResult> GetRegister(UserRegistrationRequest elearning)
        {
            elearning.Password = elearning.MobileNo;
            var res = _service.RegisterUser(elearning);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}