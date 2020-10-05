using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities.ManyToMany
{
    public class LotColor
    {
        public int Id { get; set; }

        public int? LotId { get; set; }

        public Lot Lot { get; set; }

        public int? ColorId { get; set; }

        public Color Color { get; set; }
    }
}
