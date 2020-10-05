using CrossmamaNew.DAL.Entities.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities
{
    public class Gender
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Lot> Lots { get; set; }

        public Gender()
        {
            Lots = new List<Lot>();
        }
    }
}
