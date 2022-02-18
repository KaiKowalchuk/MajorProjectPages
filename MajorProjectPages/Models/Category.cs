using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MajorProjectPages.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "Tag name must be between 3 and 40 characters!")]
        public string CategoryName { get; set; }

        public List<Produce> CateListOfProduce { get; set; }
    }
}
