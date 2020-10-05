using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities.ManyToMany
{
    public class LotStructure
    {
        public int Id { get; set; }

        public int? LotId { get; set; }

        public Lot Lot { get; set; }

        public int? StructureId { get; set; }

        public Structure Structure { get; set; }

    }
}
