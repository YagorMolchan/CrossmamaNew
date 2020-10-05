using CrossmamaNew.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Interfaces
{
    public interface ILotRepository
    {
        IEnumerable<Lot> Lots { get; }
        IEnumerable<Lot> GetLots(int genderId);

        Lot GetLot(int id);
        
        IEnumerable<Lot> GetClothes();
        IEnumerable<Lot> GetClothes(int nounId);
        IEnumerable<Lot> GetFootwear();
        IEnumerable<Lot> GetFootwear(int nounId);
    }
}
