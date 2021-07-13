using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ERPSchoolManagementWeb.Models.Custom;
using Newtonsoft.Json;

namespace ERPSchoolManagementWeb.Models.Response
{
    public class LoginResponse
    {
        public bool IsLoginSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string Profile { get; set; }
        public CustomElearningUser ProfileEntity
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Profile))
                {
                    var data = JsonConvert.DeserializeObject<CustomElearningUser>(this.Profile);
                    return data;
                }
                return (null);
            }
        }
    }
}