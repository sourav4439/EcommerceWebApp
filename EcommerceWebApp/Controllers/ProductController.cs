using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApp.Data.Interfaces;
using EcommerceWebApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        private readonly IHostingEnvironment env;
        

        public ProductController(IproductRepo iproduct,
            ICategoryrepo categoryrepo,
            ICompanyrepo  companyrepo,
            ITagrepo tagrepo, 
            IHostingEnvironment env)
        {
            this.iproduct = iproduct;
            this.categoryrepo = categoryrepo;
            this.companyrepo = companyrepo;
            this.tagrepo = tagrepo;
            this.env = env;
           
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
            CustomsMethod customsMethod = new CustomsMethod();
            var folder = Path.Combine(env.WebRootPath, "images\\shop");
            
            ViewBag.category = new SelectList(categoryrepo.GetAll(), "Id", "CateName");
            ViewBag.Company = new SelectList(companyrepo.GetAll(), "Id", "CompanyName");
            ViewBag.Tag = new SelectList(tagrepo.GetAll(), "Id", "TagName");
            if (ModelState.IsValid)
            {
                product.FeaturePhoto = customsMethod.PhotoUploadProcessing(product.FeaturePhotoupload, folder);
                product.SidePhotoOne = customsMethod.PhotoUploadProcessing(product.SidePhotoOneupload, folder);
                product.SidePhotoTwo = customsMethod.PhotoUploadProcessing(product.SidePhotoTwoupload, folder);
                product.SidePhotoThree = customsMethod.PhotoUploadProcessing(product.SidePhotoThreeupload, folder);
                iproduct.Create(product);
            }
            else
            {
                return View(product);
            }

            return RedirectToAction(nameof(ProductList));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.category = new SelectList(categoryrepo.GetAll(), "Id", "CateName");
            ViewBag.Company = new SelectList(companyrepo.GetAll(), "Id", "CompanyName");
            ViewBag.Tag = new SelectList(tagrepo.GetAll(), "Id", "TagName");
           var product= iproduct.GetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            CustomsMethod customsMethod = new CustomsMethod();
            var folder = Path.Combine(env.WebRootPath, "images\\shop");
         
            ViewBag.category = new SelectList(categoryrepo.GetAll(), "Id", "CateName");
            ViewBag.Company = new SelectList(companyrepo.GetAll(), "Id", "CompanyName");
            ViewBag.Tag = new SelectList(tagrepo.GetAll(), "Id", "TagName");
            if (ModelState.IsValid)
            {

                product.FeaturePhoto = customsMethod.PhotoUploadProcessing(product.FeaturePhotoupload, folder);
                product.SidePhotoOne = customsMethod.PhotoUploadProcessing(product.SidePhotoOneupload, folder);
                product.SidePhotoTwo = customsMethod.PhotoUploadProcessing(product.SidePhotoTwoupload, folder);
                product.SidePhotoThree = customsMethod.PhotoUploadProcessing(product.SidePhotoThreeupload, folder);
                iproduct.Update(product);
            }
            else
            {
                return View(product);
            }

            return RedirectToAction(nameof(ProductList));
        }
    }
}