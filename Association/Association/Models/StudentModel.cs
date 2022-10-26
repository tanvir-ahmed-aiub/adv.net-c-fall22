using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Association.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string StudentId { get; set; }
        [Required]
        public int DepartmentId { get; set; }

    }
}