using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Lib.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public StudentService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        //public async Task<List<Student>> GetAllStudent()
        //{
        //    var result = await _applicationDbContext.Students.ToListAsync();
        //    return result;
        //}

        public async Task<ServiceResponse<Student>> GetAllStudent()
        {
            var result = await _applicationDbContext.Students.ToListAsync();
            ServiceResponse<Student> response = new ServiceResponse<Student>();
            response.Data = result;
            return response;
        }


    }
}
