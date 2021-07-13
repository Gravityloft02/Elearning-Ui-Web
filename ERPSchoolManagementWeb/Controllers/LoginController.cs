using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using ERPSchoolManagementWeb.Models.Request;
using ERPSchoolManagementWeb.Models.Response;
using ERPSchoolManagementWeb.Interfaces;
using ERPSchoolManagementWeb.Models;
using ERPSchoolManagementWeb.Services;
using ERPSchoolManagementWeb.Helper;

namespace ERPSchoolManagementWeb.Controllers
{
    public class LoginController : Controller
    {
        IManagement _service;
        ILocation _location;
        public LoginController()
        {
            _service = new ManagementService();
            _location = new LocationService();
        }
        // GET: Login
        public async Task<ActionResult> Index()
        {
            var rl = await _service.GetRoleList();
            ViewData["Roles"] = new SelectList(rl, "Id", "RoleName");
            return View(new ElearningLoginModel());
        }

        [HttpPost]
        public async Task<JsonResult> ValidateLogin(ElearningLoginModel elearning)
        {
            var res = await _service.LoginUser(elearning);
            if (res.IsLoginSuccess)
            {
                var profile = res.ProfileEntity;

                SessionHelper.Instance.User = profile;
                
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}