using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MajorProjectPages.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "Tag name must be between 3 and 40 characters!")]
        public string FirstName { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "Tag name must be between 3 and 40 characters!")]
        public string LastName { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }

        public int PositionID { get; set; } //One to many with position
        public Position PositionObj { get; set; }
    }
}
