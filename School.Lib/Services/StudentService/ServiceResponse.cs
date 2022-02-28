using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Lib.Services.StudentService
{
    public class ServiceResponse<T>
    {
        public List<T>? Data { get; set; }
        public bool IsSuccess { get; set; }=true;   
        public string message{ get; set; }=string.Empty;

    }
}
