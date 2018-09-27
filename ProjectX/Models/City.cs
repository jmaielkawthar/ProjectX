using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectX.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }

        public string cityString { get; set; }

        public virtual ICollection<Students> student { get; set; }

    }
}