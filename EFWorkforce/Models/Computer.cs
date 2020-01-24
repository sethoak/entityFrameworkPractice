using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFWorkforce.Models
{
    public class Computer
    {

        public int Id { get; set; }
        [Required]
        [Display(Name = "Purchase Date")]
        public DateTime PurchaseDate { get; set; }
        [Display(Name = "Manufacturer")]
        public string Make { get; set; }
        public string Model { get; set; }

        [Display(Name="Decommission Date")]
        public DateTime? DecomissionDate { get; set; }

        public Employee Employee { get; set; }

    }
}