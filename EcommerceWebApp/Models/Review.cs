using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Decription { get; set; }
        public int Rating { get; set; }
        public Product product { get; set; }
        public int ProductId { get; set; }


    }
}
