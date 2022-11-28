using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UMSCodeFirst.EF.Models
{
    public class Course
    {

        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [ForeignKey("Department")]
        public int DId { get; set; }
        public virtual Department Department { get; set; }
    }
}