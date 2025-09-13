using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_task_2.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
