using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRepo
    {
        public static List<Student> Get()
        {
            var db = new UMSFall22_cEntities();
            return db.Students.ToList();
        }
    }
}
