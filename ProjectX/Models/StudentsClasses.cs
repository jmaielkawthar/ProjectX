using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectX.Models
{
    public class StudentsClasses
    {
        [Key]
        [Column(Order=1)]
        public int StudentID { get; set; }

        public virtual Students student { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ClassID { get; set; }
        
        public virtual Classes classe { get; set; }
    }
}