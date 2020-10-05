using CrossmamaNew.DAL.EF;
using CrossmamaNew.DAL.Entities.Sizes.Abstracts;
using CrossmamaNew.DAL.Entities.Sizes.Concretes;
using CrossmamaNew.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Repositories
{
    public class SizeRepository : ISizeRepository
    {
        private readonly CrossmamaDbContext _dbContext;

        public SizeRepository()
        {
            _dbContext = CrossmamaDbContext.Create();
        }

        public IEnumerable<Size> GetAfter14ClotheSizes()
        {
            return _dbContext.Sizes.Where(s => s is After14ClotheSize);
        }

        public IEnumerable<Size> GetBefore14ClotheSizes()
        {
            return _dbContext.Sizes.Where(s => s is Before14ClotheSize);
        }

        public IEnumerable<Size> GetFootwear()
        {
            return _dbContext.Sizes.Where(s => s is FootwearSize);
        }

        public Size GetSize(string value)
        {
            return _dbContext.Sizes.FirstOrDefault(s => s.Value == value);
        }
    }
}
