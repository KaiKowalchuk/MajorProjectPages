using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MajorProjectPages.Models
{
    public class Produce
    {
        [Key]
        public int ProduceID { get; set;}

        [StringLength(40, MinimumLength = 3, ErrorMessage = "Tag name must be between 3 and 40 characters!")]
        public string ProduceName { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int UnitsSold { get; set; }

        public int CategoryID { get; set; }
        public Category CategoryObj { get; set; }

        public int AisleID { get; set; }

        public Aisle AisleObj { get; set; }
    }
}
