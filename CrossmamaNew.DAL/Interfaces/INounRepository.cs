using CrossmamaNew.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Interfaces
{
    public interface INounRepository
    {
        IEnumerable<Noun> Nouns { get; }

        IEnumerable<Noun> GetNouns(int categoryId);

        Noun GetNoun(string nounName);


    }
}
