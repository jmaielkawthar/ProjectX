using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectX.Models
{
    public class Classes
    {
       [Key]

        public int ID { get; set; }

        public string Classestring { get; set; }

        public virtual ICollection<StudentsClasses> studentclasse { get; set; }

    }
}