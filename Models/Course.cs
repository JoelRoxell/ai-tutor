using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ai_tutor.Models
{
    public class Course
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }
        public ICollection<Lecture> lectures { get; set; }
    }
}