using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectX.Models
{
    public class Students
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int adresse { get; set; }
        public int cityID { get; set; }

        public virtual City city { get; set; }

        public virtual ICollection<StudentsClasses> studentclasse { get; set; }

    }
}