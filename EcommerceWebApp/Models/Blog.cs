                
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string FeatureImage { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
