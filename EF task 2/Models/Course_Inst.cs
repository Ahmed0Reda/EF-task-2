using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_task_2.Models
{
    public class Course_Inst
    {
        [Key]
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string Evaluate { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
