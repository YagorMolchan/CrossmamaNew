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
    public class CategoryRepository : ICategoryRepository
    {
        private CrossmamaDbContext _dbContext;

        public CategoryRepository()
        {
            _dbContext = CrossmamaDbContext.Create();
        }

        public IEnumerable<Category> Categories => _dbContext.Categories.ToList<Category>();

        public IEnumerable<Category> GetCategories(int sectionId)
        {
            return _dbContext.Categories.Where(c => c.SectionId == sectionId);
        }
    }
}
