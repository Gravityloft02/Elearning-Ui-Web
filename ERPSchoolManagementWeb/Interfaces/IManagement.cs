using ERPSchoolManagementWeb.Models;
using ERPSchoolManagementWeb.Models.Response;
using ERPSchoolManagementWeb.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSchoolManagementWeb.Interfaces
{
   public interface IManagement
    {
        Task<UserRegistrationResponse> RegisterUser(UserRegistrationRequest registration);
        Task<LoginResponse> LoginUser(ElearningLoginModel request);
        Task<IEnumerable<UserRoleModel>> GetRoleList();
        Task<bool> AddSchool(SchoolModel schoolrequest);
        Task<IEnumerable<SchoolModel>> GetAllSchools();
        Task<SchoolModel> GetSchoolById(int id);
        Task<bool> UpdateSchool(SchoolModel school);
        Task<bool> CancelSchool(SchoolModel school);
        Task<bool> AddTeacher(TeacherModel Teacherrequest);
        Task<IEnumerable<TeacherModel>> GetAllTeachers();
        Task<TeacherModel> GetTeacherById(int id);
        Task<bool> UpdateTeacher(TeacherModel teacher);
        //Task<bool> CancelTeacher(TeacherModel teacher);
        Task<bool> AddStudent(CustomStudentModel studentrequest);
        Task<IEnumerable<CustomStudentModel>> GetAllStudents();
        Task<CustomStudentModel> GetStudentById(int id);
        Task<bool> UpdateStudent(CustomStudentModel student);
        //Task<bool> CancelStudent(StudentModel student);

        Task<bool> AddParent(ParentModel parentrequest);
        Task<IEnumerable<ParentModel>> GetAllParents();
        Task<ParentModel> GetParentById(int id);
        Task<bool> UpdateParent(ParentModel parent);
    }
}
