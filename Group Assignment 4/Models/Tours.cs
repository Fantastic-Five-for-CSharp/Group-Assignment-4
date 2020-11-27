using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group_Assignment_4.Models
{
    public class Tours
    {
        public string total { get; set; }
        public Tour[] data { get; set; }
        public string limit { get; set; }
        public string start { get; set; }
    }

    public class Tour
    {
        [Key]
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string durationMin { get; set; }
        public string durationMax { get; set; }
        public string durationUnit { get; set; }
        
        [ForeignKey("Park")]
        public string name { get; set; }
        public Park park { get; set; }
        
        //public List<Image> images { get; set; }
        //public List<Activity> activities { get; set; }
    }
}
