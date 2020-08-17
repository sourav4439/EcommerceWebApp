using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApp.Data.Interfaces;
using EcommerceWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IproductRepo iproduct;

        public ProductController(IproductRepo iproduct)
        {
            this.iproduct = iproduct;
        }

        public IActionResult Index()
        {
            return View("product-details");
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var productlist=iproduct.GetAll();
            return View(productlist);
        }
        [HttpGet]
        public  IActionResult ProductAdd()
        {

            return View();
        }

        [HttpPost]
        public IActionResult ProductAdd(Product product)
        {

           
            return View();
        }
    }
}