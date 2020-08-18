using EcommerceWebApp.Data.Interfaces;
using EcommerceWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.Data.Repository
{
    public class Companyrepo : Repository<Company>, ICompanyrepo
    {
        public Companyrepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
