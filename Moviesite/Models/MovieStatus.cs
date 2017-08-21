using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Moviesite.Models
{
    public class MovieStatus
    {
        public byte Id { get; set; }

        public int AgeOfMovie { get; set; }

        public double PriceOfMovie { get; set; }
    }
}