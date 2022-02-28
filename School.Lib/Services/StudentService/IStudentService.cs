using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Lib.Services.StudentService
{
    public interface IStudentService:Iservice
    {
        Task<ServiceResponse<Student>> GetAllStudent();
    }
}
