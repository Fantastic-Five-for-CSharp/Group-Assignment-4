using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group_Assignment_4.Models
{
    public class Tours
    {
        public string? total { get; set; }
        public Tour[]? data { get; set; }
        public string? limit { get; set; }
        public string? start { get; set; }
    }

    public class Tour
    {
        [Key]
        public string? id { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Tour Title")]
        public string? title { get; set; }

        [Column(TypeName = "nvarchar(2000)")]
        public string? description { get; set; }

        public string? durationMin { get; set; }
        public string? durationMax { get; set; }
        public string? durationUnit { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Park Code")]
        public string? ParkCode { get; set; }
        public string? parkCode { get; set; }
        public string? name { get; set; }
       
    }
}
