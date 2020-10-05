using CrossmamaNew.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Interfaces
{
    public interface IStateRepository
    {
        IEnumerable<State> States { get; }

        State GetState(string name);
    }
}
