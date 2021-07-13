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
    public class ParentController : Controller
    {
        IManagement _service;
        ILocation _location;
        public ParentController()
        {
            _service = new ManagementService();
            _location = new LocationService();
        }
        // GET: Management/Teachers
        public async Task<ActionResult> Index()
        {
            //var user = ERPSchoolManagementWeb.Helper.SessionHelper.Instance.User;
            var res = await _service.GetAllParents();
            var result = res.OrderByDescending(x => x.Id);
            return View(result);
        }

        [HttpGet]
        public async Task<ActionResult> New()
        {
            return View(new ParentModel());
        }

        [HttpPost]
        public async Task<JsonResult> AddParent(ParentModel parent)
        {
            var res = await _service.AddParent(parent);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}