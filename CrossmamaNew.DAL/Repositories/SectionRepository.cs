using CrossmamaNew.DAL.EF;
using CrossmamaNew.DAL.Entities;
using CrossmamaNew.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private readonly CrossmamaDbContext _dbContext;

        public SectionRepository()
        {
            _dbContext = CrossmamaDbContext.Create();
        }
        public IEnumerable<Section> Sections { get => _dbContext.Sections; }
    }
}
