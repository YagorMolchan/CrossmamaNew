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
    public class StateRepository : IStateRepository
    {
        private CrossmamaDbContext _dbContext;

        public StateRepository()
        {
            _dbContext = CrossmamaDbContext.Create();
        }

        public IEnumerable<State> States => _dbContext.States;

        public State GetState(string name)
        {
            return _dbContext.States.FirstOrDefault(s => s.Name == name);
        }
    }
}
