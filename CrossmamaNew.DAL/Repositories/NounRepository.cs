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
    public class NounRepository : INounRepository
    {
        private CrossmamaDbContext _dbContext;

        public IEnumerable<Noun> Nouns =>_dbContext.Nouns;

        public IEnumerable<Noun> GetNouns(int categoryId)
        {
            return _dbContext.Nouns.Where(c => c.CategoryId == categoryId);
        }

        public Noun GetNoun(string nounName)
        {
            return _dbContext.Nouns.FirstOrDefault(n => n.Name == nounName);
        }
    }
}
