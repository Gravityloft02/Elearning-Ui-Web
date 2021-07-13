using ERPSchoolManagementWeb.Interfaces;
using ERPSchoolManagementWeb.Models;
using ERPSchoolManagementWeb.Models.Response;
using ERPSchoolManagementWeb.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ERPSchoolManagementWeb.Services
{
    public class ManagementService:BaseService, IManagement
    {

        #region Elearning

        
        public async Task<LoginResponse> LoginUser(ElearningLoginModel request)
        {
            var res = await ServiceCallAsync<LoginResponse>("api/Registration/Login", request, null);
            return res;
        }

        
        public async Task<UserRegistrationResponse> RegisterUser(UserRegistrationRequest registration)
        {
            var res = await ServiceCallAsync<UserRegistrationResponse>("api/Registration/Register",registration, null);
            return res;
        }
        public async Task<IEnumerable<UserRoleModel>> GetRoleList()
        {
            var roles = await ServiceCallAsync<List<UserRoleModel>>("api/Registration/UserRole/All", "");
            return roles;
        }
        #endregion

        #region School
        public async Task<bool> AddSchool(SchoolModel schoolrequest)
        {
            var res = await ServiceCallAsync<bool>("School/Add", schoolrequest, null);
            return res;
        }

        public async Task<IEnumerable<SchoolModel>> GetAllSchools()
        {
            var res = await ServiceCallAsync<List<SchoolModel>>("School/All", null, null);
            var result = GetSchool(res);
            return result;
        }
        private List<SchoolModel> GetSchool(IEnumerable<SchoolModel> schools)
        {
            List<SchoolModel> list = new List<SchoolModel>();
            if (schools != null)
            {
                foreach (var item in schools)
                {
                    list.Add(new SchoolModel()
                    {
                        Id = item.Id,
                        SchoolAddress = item.SchoolAddress,
                        SchoolName = item.SchoolName,
                        StateId = item.StateId,
                        CityId = item.CityId,
                        LocalityId = item.LocalityId,
                        Email = item.Email,
                        PhoneNo = item.PhoneNo,
                        MobileNo = item.MobileNo,
                        Pincode= item.Pincode,
                        PrincipalName = item.PrincipalName,
                        IsActive = item.IsActive

                    });

                }
            }
            return list;
        }
        public async Task<SchoolModel> GetSchoolById(int id)
        {
            var res = await ServiceCallAsync<SchoolModel>("School/school/" + id, "", null);
            return res;
        }

        public async Task<bool> UpdateSchool(SchoolModel school)
        {
            var res = await ServiceCallAsync<bool>("School/Edit", school, null);
            return res; 
        }

        public async Task<bool> CancelSchool(SchoolModel school)
        {
            var res = await ServiceCallAsync<bool>("School/Cancel", school, null);
            return res;
        }
        #endregion

        #region Parent
        public async Task<bool> AddParent(ParentModel parentrequest)
        {
            var res = await ServiceCallAsync<bool>("Parent/Add", parentrequest, null);
            return res;
        }

        public async Task<IEnumerable<ParentModel>> GetAllParents()
        {
            var res = await ServiceCallAsync<List<ParentModel>>("Parent/All", null, null);
            var result = GetParent(res);
            return result;
        }
        private List<ParentModel> GetParent(IEnumerable<ParentModel> parents)
        {
            List<ParentModel> list = new List<ParentModel>();
            if (parents != null)
            {
                foreach (var item in parents)
                {
                    list.Add(new ParentModel()
                    {
                        Id = item.Id,
                        Email = item.Email,
                        PhoneNo = item.PhoneNo,
                        MobileNo = item.MobileNo,
                        CreatedDate = item.CreatedDate,
                        DateOfJoin = item.DateOfJoin,
                        Dob = item.Dob,
                        FirstName = item.FirstName,
                        LastLoginDate = item.LastLoginDate ,
                         LastName = item.LastName, 
                         Password = item.Password,
                         Status = item.Status
                    });

                }
            }
            return list;
        }
        public async Task<ParentModel> GetParentById(int id)
        {
            var res = await ServiceCallAsync<ParentModel>("Parent/parent/" + id, "", null);
            return res;
        }

        public async Task<bool> UpdateParent(ParentModel parent)
        {
            var res = await ServiceCallAsync<bool>("Parent/Edit", parent, null);
            return res;
        }

        #endregion

        #region Student
        public async Task<bool> AddStudent(CustomStudentModel Studentrequest)
        {
            var res = await ServiceCallAsync<bool>("Student/Add", Studentrequest, null);
            return res;
        }

        public async Task<IEnumerable<CustomStudentModel>> GetAllStudents()
        {
            var res = await ServiceCallAsync<List<CustomStudentModel>>("Student/All", null, null);
            var result = GetStudent(res);
            return result;
        }
        private List<CustomStudentModel> GetStudent(IEnumerable<CustomStudentModel> students)
        {
            List<CustomStudentModel> list = new List<CustomStudentModel>();
            if (students != null)
            {
                foreach (var user in students)
                {
                    list.Add(new CustomStudentModel()
                    {
                        Sno = user.Sno,
                        City = user.City,
                        Adharno = user.Adharno,
                        AdmNo = user.AdmNo,
                        AllergyMedDesc = user.AllergyMedDesc,
                        EmgAddress = user.EmgAddress,
                        FathersAnnualincome = user.FathersAnnualincome,
                        Incaseofemgname = user.Incaseofemgname,
                        FathersOffaddress = user.FathersOffaddress,
                        Weight = user.Weight,
                        BloodGroup = user.BloodGroup,
                        Caste = user.Caste,
                        Class = user.Class,
                        Dateofadmission = user.Dateofadmission,
                        EmgMobno = user.EmgMobno,
                        EmgPhoneno = user.EmgPhoneno,
                        FathersEmail = user.FathersEmail,
                        MothersEmail = user.MothersEmail,
                        MedicalAddress = user.MedicalAddress,
                        MothersAnnualincome = user.MothersAnnualincome,
                        MothersDesignation = user.MothersDesignation,
                        MothersDob = user.MothersDob,
                        MothersMobno = user.MothersMobno,
                        MothersName = user.MothersName,
                        MothersOffaddress = user.MothersOffaddress,
                        MothersProfession = user.MothersProfession,
                        MothersResaddress = user.MothersResaddress,
                        FathersMobno = user.FathersMobno,
                        FamilyDoc = user.FamilyDoc,
                        FathersDesignation = user.FathersDesignation,
                        FathersDob = user.FathersDob,
                        FathersName = user.FathersName,
                        FathersProfession = user.FathersProfession,
                        FathersResaddress = user.FathersResaddress,
                        Gender = user.Gender,
                        Height = user.Height,
                        Nationality = user.Nationality,
                        Relation = user.Relation,
                        Religion = user.Religion,
                        StudentRegNo = user.StudentRegNo,
                        SamgraId = user.SamgraId,
                        Section = user.Section,
                        SmsDetailaltmobno = user.SmsDetailaltmobno,
                        SmsDetailemail = user.SmsDetailemail,
                        SmsDetailmobno = user.SmsDetailmobno,
                        SmsSendername = user.SmsSendername,
                        State = user.State,
                        StudentAddress = user.StudentAddress,
                        StudentCategory = user.StudentCategory,
                        StudentDob = user.StudentDob,
                        StudentImage = user.StudentImage,
                        StudentName = user.StudentName,
                        StudetType = user.StudetType,
                        Timeofsync = user.Timeofsync
                    });

                }
            }
            return list;
        }
        public async Task<CustomStudentModel> GetStudentById(int id)
        {
            var res = await ServiceCallAsync<CustomStudentModel>("Student/Student/" + id, "", null);
            return res;
        }

        public async Task<bool> UpdateStudent(CustomStudentModel Student)
        {
            var res = await ServiceCallAsync<bool>("Student/Edit", Student, null);
            return res;
        }
        #endregion

        #region Teacher
        public async Task<bool> AddTeacher(TeacherModel Teacherrequest)
        {
            var res = await ServiceCallAsync<bool>("Teacher/Add", Teacherrequest, null);
            return res;
        }

        public async Task<IEnumerable<TeacherModel>> GetAllTeachers()
        {
            var res = await ServiceCallAsync<List<TeacherModel>>("Teacher/All", null, null);
            var result = GetTeacher(res);
            return result;
        }
        private List<TeacherModel> GetTeacher(IEnumerable<TeacherModel> teachers)
        {
            List<TeacherModel> list = new List<TeacherModel>();
            if (teachers != null)
            {
                foreach (var item in teachers)
                {
                    list.Add(new TeacherModel()
                    {
                        Id = item.Id,
                        Email = item.Email,
                        PhoneNo = item.PhoneNo,
                        MobileNo = item.MobileNo,
                        CreatedDate = item.CreatedDate,
                        DateOfJoin = item.DateOfJoin,
                        Dob = item.Dob,
                        FirstName = item.FirstName,
                        LastLoginDate = item.LastLoginDate,
                        LastName = item.LastName,
                        Password = item.Password,
                        Status = item.Status
                        
                    });

                }
            }
            return list;
        }
        public async Task<TeacherModel> GetTeacherById(int id)
        {
            var res = await ServiceCallAsync<TeacherModel>("Teacher/teacher/" + id, "", null);
            return res;
        }

        public async Task<bool> UpdateTeacher(TeacherModel teacher)
        {
            var res = await ServiceCallAsync<bool>("Teacher/Edit", teacher, null);
            return res;
        }
        #endregion


    }
}