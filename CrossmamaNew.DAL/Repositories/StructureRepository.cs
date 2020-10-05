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
    public class StructureRepository : IStructureRepository
    {
        private CrossmamaDbContext _dbContext;

        public StructureRepository()
        {
            _dbContext = CrossmamaDbContext.Create();
        }


        public IEnumerable<Structure> Structures => _dbContext.Structures;

        public Structure GetStructure(string name)
        {
            return _dbContext.Structures.FirstOrDefault(s => s.Name == name);
        }
    }
}
