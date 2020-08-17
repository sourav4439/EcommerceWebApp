using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string WebId { get; set; }
        public string Condition { get; set; }
        public string BandName { get; set; }
        public string Description { get; set; }        
        public double Price { get; set; }
        public string FeaturePhoto { get; set; }
        public string SidePhotoOne { get; set; }
        public string SidePhotoTwo { get; set; }
        public string SidePhotoThree { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public Review Review { get; set; }
        public int ReviewId { get; set; }
        public Tag Tag { get; set; }
        public int TagId { get; set; }




    }
}
