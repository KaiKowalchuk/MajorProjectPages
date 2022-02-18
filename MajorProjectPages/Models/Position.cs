using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MajorProjectPages.Models
{
    public class Position
    {
        [Key]
        public int PositionID { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "Tag name must be between 3 and 40 characters!")]
        public string Title { get; set; }

       public List<Employee> ListOFEmployees { get; set; }
    }
}
