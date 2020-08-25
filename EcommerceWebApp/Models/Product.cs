using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string WebId { get; set; }
        [Required]
        public string Condition { get; set; }
        [Required]
        public string BandName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }

        public string FeaturePhoto { get; set; }
        public string SidePhotoOne { get; set; }
        public string SidePhotoTwo { get; set; }
        public string SidePhotoThree { get; set; }
        public Category Category { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public int CategoryId { get; set; }
        public Company Company { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public int CompanyId { get; set; }       
        public Tag Tag { get; set; }
        [Required]
        [Display(Name = "Tag Name")]
        public int TagId { get; set; }

        [NotMapped]
        [Required]
        public IFormFile FeaturePhotoupload { get; set; }
        [NotMapped]
        [Required]
        public IFormFile SidePhotoOneupload { get; set; }
        [NotMapped]
        [Required]
        public IFormFile SidePhotoTwoupload { get; set; }
        [NotMapped]
        [Required]
        public IFormFile SidePhotoThreeupload { get; set; }

    }
}
