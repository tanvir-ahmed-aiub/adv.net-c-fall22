using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentService
    {
        public static List<StudentDTO> GetStudents() { 
            var list = new List<StudentDTO>();  
            foreach(var st in StudentRepo.Get())
            {
                list.Add(new StudentDTO() { Id = st.Id, Name=st.Name});
            }
            return list;
        }
    }
}
