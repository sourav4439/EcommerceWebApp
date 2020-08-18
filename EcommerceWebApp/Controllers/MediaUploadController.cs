using EcommerceWebApp.Data.Interfaces;
using EcommerceWebApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;

namespace EcommerceWebApp.Controllers
{
    public class MediaUploadController : Controller
    {
        private readonly IMediarepo imediarepo;

        private readonly IHostingEnvironment env;

        CustomsMethod customsMethod = new CustomsMethod();
        public MediaUploadController(IMediarepo imediarepo, IHostingEnvironment env)
        {
            this.imediarepo = imediarepo;
            this.env = env;
        }

        [HttpGet]
        public IActionResult MediaGallary()
        {
            var media = imediarepo.GetAll();
            return View(media);
        }
        [HttpGet]
        public IActionResult AddMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMedia(List<IFormFile> iformfile)
        {
            var folder = Path.Combine(env.WebRootPath, "images\\shop");

            foreach (var item in iformfile)
            {
                var res = customsMethod.PhotoUploadProcessing(item, folder);
                if (res.Contains("Uploding Fail"))
                {
                    ViewBag.Massage(res);
                    return View();
                }
                Media media = new Media();
                media.FilePath = res;
                imediarepo.Create(media);
            }


            return RedirectToAction("MediaGallary");
        }
    }
}