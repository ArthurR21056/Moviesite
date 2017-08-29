using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Moviesite.Models;

namespace Moviesite.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

       // [Min18YearsIfMember]
        public DateTime Birthdate { get; set; }

        public byte MembershipTypeId { get; set; }

    }
}