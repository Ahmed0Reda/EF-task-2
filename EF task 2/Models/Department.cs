using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_task_2.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int Serial {  get; set; }
    }
}
