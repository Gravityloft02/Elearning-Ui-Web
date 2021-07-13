using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ERPSchoolManagementWeb.Models;
using ERPSchoolManagementWeb.Models.Custom;

namespace ERPSchoolManagementWeb.Helper
{
    public class SessionHelper
    {
        private static SessionHelper _instance;

        public static SessionHelper Instance
        {

            get
            {

                if (_instance == null)
                {
                    _instance = new SessionHelper();
                }
                return _instance;
            }

        }

      
        public CustomElearningUser User
        {
            get
            {
                var _User = HttpContext.Current.Session["LoggedInUser"] as CustomElearningUser;
                return _User;
            }
            set
            {
                HttpContext.Current.Session["LoggedInUser"] = value;
            }
        }


    }
}