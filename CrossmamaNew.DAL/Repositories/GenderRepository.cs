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
    public class GenderRepository : IGenderRepository
    {
        private CrossmamaDbContext _dbContext;

        public GenderRepository()
        {
            _dbContext = CrossmamaDbContext.Create();
        }

        public IEnumerable<Gender> Genders => _dbContext.Genders;

        public Gender GetGender(string name)
        {
            return _dbContext.Genders.FirstOrDefault(g => g.Name == name);
        }
    }
}
