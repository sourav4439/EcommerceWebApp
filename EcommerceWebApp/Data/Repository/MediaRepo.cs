using EcommerceWebApp.Data.Interfaces;
using EcommerceWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.Data.Repository
{
    public class MediaRepo : Repository<Media>, IMediarepo
    {
        public MediaRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
