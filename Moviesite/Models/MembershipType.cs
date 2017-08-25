using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;


namespace Moviesite.Models
{
    public class MembershipType
    {
        public int Id { get; set; }

        public short SignUpFee { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public int DurationInMonths { get; set; }

        public int DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 0;

    }
}