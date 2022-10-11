using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void PrintArray(int[] array) {
            foreach (var item in array) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static List<Student> GetStudents() {
            var students = new List<Student>();
            for (int i = 1; i < 100; i++) {
                students.Add(new Student() { 
                    Id = i,
                    Name = "Student " + i
                });
            }
            return students;
        }

        static void ShowStudents(List<Student> students)
        {
            foreach (var student in students) {
                student.ShowInfo();
            }
        }


        static void Main(string[] args)
        {
            var marks = new int[] { 32, 45, 65, 34, 50, 87, 78, 90, 65 };
            PrintArray(marks);  
            var filtered =  (from mark in marks
                            where mark >=50
                            select mark).ToArray();
            /*var filtered = new int[marks.Length];
            int countPass = 0;

            foreach (var mark in marks) {
                if (mark >= 50) { 
                    filtered[countPass++] = mark;
                }
            }*/
            PrintArray(filtered);

            var students = GetStudents();// database
            var last10 = (from st in students
                         where st.Id >=90
                         select st).ToList();
            ShowStudents(last10);

            var midd50 = (from st1 in students
                          where st1.Id >= 30 && st1.Id <= 80
                          select st1).ToList();
            ShowStudents(midd50);


        }
    }
}
