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
    public class LotRepository : ILotRepository
    {
        private readonly CrossmamaDbContext _dbContext;

        public IEnumerable<Lot> Lots => _dbContext.Lots;

        public IEnumerable<Lot> GetClothes()
        {
            return _dbContext.Lots.Where(l => l.Noun.CategoryId != 1);
        }

        public IEnumerable<Lot> GetClothes(int nounId)
        {
            return _dbContext.Lots.Where(l => l.NounId == nounId && l.Noun.CategoryId!=1);
        }

        public IEnumerable<Lot> GetFootwear()
        {
            return _dbContext.Lots.Where(l => l.Noun.CategoryId == 1);
        }

        public IEnumerable<Lot> GetFootwear(int nounId)
        {
            return _dbContext.Lots.Where(l => l.NounId == nounId && l.Noun.CategoryId == 1);
        }

        public Lot GetLot(int id)
        {
            return _dbContext.Lots.FirstOrDefault(l => l.Id == id);
        }

        public IEnumerable<Lot> GetLots(int genderId)
        {
            return _dbContext.Lots.Where(l => l.GenderId == genderId);
        }
    }
}
