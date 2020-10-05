using CrossmamaNew.DAL.Entities.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities
{
    public class Noun
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Lot> Lots { get; set; }

        public Noun()
        {
           Lots = new List<Lot>();
        }
    }
}
