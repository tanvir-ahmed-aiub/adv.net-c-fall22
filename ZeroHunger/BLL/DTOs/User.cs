using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class User
    {
        public int Id { get; set; }
        public string Uname { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
    }
}
