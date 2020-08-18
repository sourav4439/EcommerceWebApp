using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApp.Data.Interfaces;
using EcommerceWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EcommerceWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IproductRepo iproduct;
        private readonly ICategoryrepo categoryrepo;
        private readonly ICompanyrepo companyrepo;
        private readonly ITagrepo tagrepo;

        public ProductController(IproductRepo iproduct,ICategoryrepo categoryrepo,ICompanyrepo  companyrepo,ITagrepo tagrepo)
        {
            this.iproduct = iproduct;
            this.categoryrepo = categoryrepo;
            this.companyrepo = companyrepo;
            this.tagrepo = tagrepo;
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
            ViewBag.category = new SelectList( categoryrepo.GetAll(),"Id","CateName");
            ViewBag.Company = new SelectList( companyrepo.GetAll(),"Id", "CompanyName");
            ViewBag.Tag= new SelectList( tagrepo.GetAll(),"Id", "TagName");
            return View();
        }

        [HttpPost]
        public IActionResult ProductAdd(Product product)
        {

           
            return View();
        }
    }
}