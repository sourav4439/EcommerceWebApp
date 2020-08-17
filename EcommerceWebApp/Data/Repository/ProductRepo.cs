using EcommerceWebApp.Data.Interfaces;
using EcommerceWebApp.Models;

namespace EcommerceWebApp.Data.Repository
{
    class ProductRepo : Repository<Product>, IproductRepo
    {
        public ProductRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }


    }
}

