using CrossmamaNew.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Interfaces
{
    public interface IStructureRepository
    {
        IEnumerable<Structure> Structures { get; }

        Structure GetStructure(string name);
    }
}
