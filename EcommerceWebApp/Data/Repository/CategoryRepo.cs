using EcommerceWebApp.Data.Interfaces;
using EcommerceWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.Data.Repository
{
    public class CategoryRepo : Repository<Category>, ICategoryrepo
    {
        public CategoryRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
