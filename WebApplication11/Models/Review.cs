using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        [Display(Name = "Album")]
        public int AlbumID { get; set; }
        public virtual Album Album { get; set; }

        public string Contents { get; set; }

        [Required()]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}