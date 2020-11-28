using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group_Assignment_4.Models
{
    public class Camps
    {
        public string? total { get; set; }
        public Camp[]? data { get; set; }
        public string? limit { get; set; }
        public string? start { get; set; }
    }

    public class Camp
    {
        [Key]
        public string? id { get; set; }
        public string? name { get; set; }
        public string? parkCode { get; set; }
        public string? description { get; set; }
        public string? reservationInfo { get; set; }
        public string? reservationUrl { get; set; }
        
       
        
        //public List<Image> images { get; set; }
        //public List<Activity> activities { get; set; }
    }
}
