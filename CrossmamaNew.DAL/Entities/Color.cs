using CrossmamaNew.DAL.Entities.ManyToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities
{
    public class Color
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<LotColor> LotColors { get; set; }

        public Color()
        {
            LotColors = new List<LotColor>();
        }


    }
}
