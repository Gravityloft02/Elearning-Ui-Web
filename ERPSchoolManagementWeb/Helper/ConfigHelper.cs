using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ERPSchoolManagementWeb.Helper
{
    public class ConfigHelper
    {
        private const string _BASEURL = "baseUrl";
        const string MAP_KEY = "mapKey";
        private const string _URL_CATEGORY = "categoryUrl";
        private const string _UPLOADLOCATION = "uploadlocation";
        const string BASEURL_EMAIL = "BaseURL_Email";
        const string EMAIL_API = "Email_Api";
        const string EMAIL_TOKEN_API = "Email_Token_Api";
        const string FROMEMAIL = "fromEmail";
        const string TOEMAIL = "toEmail";
        const string FROMPASSWORD = "fromPassword";
        const string EMAILDISPLAYNAME = "emailDisplayName";
        const string SPLITCHARACTER = "splitChar";
        const string CONTACTUSSUBJECT = "ContactUsSubject";
        const string TEMPLATE_IMG_URL = "url";
        const string _BASE_FOLDER = "baseFolder";
        const string BASEURL_PDF = "BaseURL_PDF";
        const string PDF_API = "PDF_Api";
        static NameValueCollection ConfigAppSettings
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings;
            }
        }

        public static string UPLOAD_LOCATION
        {
            get
            {
                return Convert.ToString(ConfigAppSettings[_UPLOADLOCATION]);
            }
        }

        public static string BASE_URL
        {
            get
            {
                return Convert.ToString(ConfigAppSettings[_BASEURL]);
            }
        }
        
        public static string SECURITY_KEY
        {
            get
            {
                return String.Empty;
            }
        }
        public static string MapKey
        {
            get
            {
                string _key = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings[MAP_KEY]);
                return _key;
            }
        }
        
        public static char SplitChar
        {
            get
            {
                char _splitChar = Convert.ToChar(ConfigurationManager.AppSettings[SPLITCHARACTER]);
                return _splitChar;
            }
        }

        public static string FromEmailDisplayName
        {
            get
            {
                string _displayName = Convert.ToString(ConfigurationManager.AppSettings[EMAILDISPLAYNAME]);
                return _displayName;
            }
        }

        public static string FromEmail
        {
            get
            {
                string _from = Convert.ToString(ConfigurationManager.AppSettings[FROMEMAIL]);
                return _from;
            }
        }

        public static List<string> ToEmail
        {
            get
            {
                string _to = Convert.ToString(ConfigurationManager.AppSettings[TOEMAIL]);
                var _list = _to.Split(SplitChar);
                if (_list != null)
                {
                    return _list.ToList();
                }
                else
                {
                    return new List<string>();
                }

            }
        }

        public static string FromPassword
        {
            get
            {
                string _pass = Convert.ToString(ConfigurationManager.AppSettings[FROMPASSWORD]);
                return _pass;
            }
        }

        public static string EmailBaseUrl
        {
            get
            {
                string _emailbase = Convert.ToString(ConfigurationManager.AppSettings[BASEURL_EMAIL]);
                return _emailbase;
            }
        }

        public static string EmailApi
        {
            get
            {
                string _emailapi = Convert.ToString(ConfigurationManager.AppSettings[EMAIL_API]);
                return _emailapi;
            }
        }

        public static string EmailTokenApi
        {
            get
            {
                string _tokenApi = Convert.ToString(ConfigurationManager.AppSettings[EMAIL_TOKEN_API]);
                return _tokenApi;
            }
        }

        public static string ContactSubject
        {
            get
            {
                string _subject = Convert.ToString(ConfigurationManager.AppSettings[CONTACTUSSUBJECT]);
                return _subject;
            }
        }

        public static string TemplateImgUrl
        {
            get
            {
                string _templateimg = Convert.ToString(ConfigurationManager.AppSettings[TEMPLATE_IMG_URL]);
                return _templateimg;
            }
        }

        public static string PDFBaseUrl
        {
            get
            {
                string _pdfbase = Convert.ToString(ConfigurationManager.AppSettings[BASEURL_PDF]);
                return _pdfbase;
            }
        }

        public static string PDFApi
        {
            get
            {
                string _pdfapi = Convert.ToString(ConfigurationManager.AppSettings[PDF_API]);
                return _pdfapi;
            }
        }


        #region ERPSchoolManagementWeb Enum

        public enum RequestType
        {
            Get,
            Post,
            //Put,
            //Delete
        }

        #endregion
    }
}