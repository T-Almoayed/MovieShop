using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShop.Models
{
    public class Class1
    {
        public int Id { get; set; }
        [Required, ]
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Actor { get; set; }
        public decimal Price { get; set; }

    }
}