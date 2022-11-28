using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UMSCodeFirst.EF.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public double? Cgpa { get; set; }
        [ForeignKey("Department")]
        public int? DId { get; set; }
        public virtual Department Department { get; set; }
    }

}