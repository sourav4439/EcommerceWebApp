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

namespace EcommerceWebApp.Controllers
{
    public class MediaUploadController : Controller
    {
        private readonly IMediarepo imediarepo;

        private readonly IHostingEnvironment env;

        CustomsMethod customsMethod = new CustomsMethod();
        public MediaUploadController( IMediarepo imediarepo,IHostingEnvironment env )
        {
            this.imediarepo = imediarepo;
            this.env = env;
        }

        [HttpGet]
        public IActionResult MediaGallary()
        {
           var media= imediarepo.GetAll();
            return View(media);
        }
        [HttpGet]
        public IActionResult AddMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMedia(IFormFile iformfile)
        {
            var folder= Path.Combine(env.WebRootPath, "images\\shop");
            var res= customsMethod.PhotoUploadProcessing(iformfile,folder);
            if(res.Contains("Uploding Fail"))
            {
                ViewBag.Massage(res);
                return View();
            }
            Media media = new Media();
            media.FilePath = res;
            imediarepo.Create(media);

            return RedirectToAction("MediaGallary");
        }
    }
}