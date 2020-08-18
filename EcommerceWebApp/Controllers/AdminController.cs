using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebApp.Data.Interfaces;
using EcommerceWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICategoryrepo categoryrepo;
        private readonly ICompanyrepo companyrepo;
        private readonly ITagrepo tagrepo;

        public AdminController(ICategoryrepo categoryrepo,ICompanyrepo companyrepo,ITagrepo tagrepo)
        {
            this.categoryrepo = categoryrepo;
            this.companyrepo = companyrepo;
            this.tagrepo = tagrepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
           var categories= categoryrepo.GetAll();
            return View(categories);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
             categoryrepo.Create(category);
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public IActionResult AddCompany()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCompany(Company company)
        {
            companyrepo.Create(company);
            return RedirectToAction("CompanyList");
        }
        [HttpGet]
        public IActionResult CompanyList()
        {
            var categories = companyrepo.GetAll();
            return View(categories);
        }
        [HttpGet]
        public IActionResult AddTag()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTag(Tag tag)
        {
            tagrepo.Create(tag);
            return RedirectToAction("TagList");
        }
        [HttpGet]
        public IActionResult TagList()
        {
            var tag = tagrepo.GetAll();
            return View(tag);
        }
    }
}