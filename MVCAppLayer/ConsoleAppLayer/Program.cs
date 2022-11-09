using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = StudentService.GetStudents();
            foreach (var st in data) { 
                Console.WriteLine("Id: {0}, Name: {1}",st.Id,st.Name);
            }
        }
    }
}
