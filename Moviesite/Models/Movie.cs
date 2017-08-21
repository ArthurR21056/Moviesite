using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Moviesite.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int Quantity { get; set; }
        public String Description { get; set; }

        public int NumberOfRentalThisYear { get; set; }

        public bool IsNewMovie { get; set; }

        [Display(Name = "Price of Moive")]
        public double PriceOfMovie { get; set; }
          
    }
}