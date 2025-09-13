using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_task_2.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public ICollection<Stud_Course> Stud_Courses { get; set; }
        public ICollection<Course_Inst> course_inst { get; set; }
    }
}
