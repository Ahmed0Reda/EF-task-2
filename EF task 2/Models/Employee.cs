using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task_1.Models
{
    public class Employee
    {
        public enum Grade
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
            E = 5
        }
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        [MinLength(5)]
        public string? Name { get; set; }
        [Required]
        [DefaultValue(4000)]
        public decimal? Salary { get; set; }
        [Range(18, 60)]
        [AllowedValues(24, 25, 26, 27)]
        [DeniedValues(10)]
        public int Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [NotMapped]
        public int test { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Address { get; set; }

    }
}
