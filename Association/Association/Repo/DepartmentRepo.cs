using Association.DB;
using Association.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Association.Repo
{
    public class DepartmentRepo
    {
        public static List<DepartmentModel> Get()
        {
            var db = new UMSFall22_cEntities();
            var depts= new List<DepartmentModel>();
            foreach (var d in db.Departments)
            {
                depts.Add(new DepartmentModel()
                {

                    Id = d.Id,
                    Name = d.Name,
                    
                });
            }
            return depts;
            //return all students of db in usable format of app
        }
        
    }
}