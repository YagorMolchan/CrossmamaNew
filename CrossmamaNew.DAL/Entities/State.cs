using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities
{
    public class State
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Lot> Lots { get; set; }


        public State()
        {
            Lots = new List<Lot>();
        }
    }
}
