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
    public class ColorRepository : IColorRepository
    {
        private CrossmamaDbContext _dbContext;

        public ColorRepository()
        {
            _dbContext = CrossmamaDbContext.Create();
        }

        public IEnumerable<Color> Colors => _dbContext.Colors;

        public Color GetColor(string name)
        {
            return _dbContext.Colors.FirstOrDefault(c => c.Name == name);
        }
    }
}
