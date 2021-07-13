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
    public class SchoolsController : Controller
    {
        IManagement _service;
        ILocation _location;

        public SchoolsController()
        {
            _service = new ManagementService();
            _location = new LocationService();
        }
        // GET: Management/Schools
        public async Task<ActionResult> Index()
        {
            //var user = ERPSchoolManagementWeb.Helper.SessionHelper.Instance.User;
            var res = await _service.GetAllSchools();
            var result = res.OrderByDescending(x => x.Id);
            return View(result);
        }

        [HttpGet]
        public async Task<ActionResult> New()
        {

            var st = await _location.GetStates();
            ViewData["State"] = new SelectList(st, "Id", "StateName");


            ViewData["City"] = new SelectList(new List<CityModel>(), "Id", "CityName");
            ViewData["Locality"] = new SelectList(new List<LocalityModel>(), "Id", "LocalArea");
            return View(new SchoolModel());
        }
        [HttpGet]
        public async Task<JsonResult> GetCities(int Id)
        {
            var data = await _location.GetCities(Id);
            return Json(data,JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public async Task<JsonResult> GetLocalities(int Id)
        {
            var data1 = await _location.GetLocalities(Id);
            return Json(data1,JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public async Task<JsonResult> AddSchool(SchoolModel school)
        {
            var res = await _service.AddSchool(school);
            return Json(res,JsonRequestBehavior.AllowGet);
        }
    }
}