using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godisbutiken12.Models
{
    public class GodisRepository : IGodisRepository
    {
        private readonly AppDbContext _appDbContext;
        public GodisRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Godis> GetAllGodis 
        {
            get
            {
                return _appDbContext.Godisar.Include(c => c.Category);
            }
         
        }

        public IEnumerable<Godis> GetGodisOnSale
        {
            get
            {
                return _appDbContext.Godisar.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Godis GetGodisById(int GodisId)
        {
            return _appDbContext.Godisar.FirstOrDefault(c => c.GodisID == GodisId);
        }
    }
}
