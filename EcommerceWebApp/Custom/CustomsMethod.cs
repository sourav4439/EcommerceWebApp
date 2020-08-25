using EcommerceWebApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp
{
    public class CustomsMethod
    {
        
        


        public string PhotoUploadProcessing(IFormFile uploadfile,string folder)
        {
            
            string fileName = uploadfile.FileName;
            string FileExtension = fileName.Substring(fileName.LastIndexOf('.') + 1).ToLower();
            if (FileExtension == "jpeg" || FileExtension == "png" || FileExtension == "jpg")
            {
                
                string newfilename = uploadfile.FileName.Replace(uploadfile.FileName, "Product") + "_" + Guid.NewGuid().ToString()+"."+ FileExtension;
                string uploadedfilepath = Path.Combine(folder, newfilename);
                uploadfile.CopyTo(new FileStream(uploadedfilepath, FileMode.Create));


                return newfilename;


            }
            else
            {
                return "Uploding Fail";

            }
        }
        public void Photodeleteprocess(string file, string folder)
        {
            if (File.Exists(Path.Combine(folder, file)))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(folder, file));
               
            }
            
        }
    }
}
