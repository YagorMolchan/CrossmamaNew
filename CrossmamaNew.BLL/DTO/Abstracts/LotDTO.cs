using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.BLL.DTO.Abstracts
{
    public abstract class LotDTO
    {
        public string NownName { get; set; }

        public string GenderName { get; set; }

        public string StateName { get; set; }

        public string ImageFile { get; set; }

        public IEnumerable<string> ColorList { get; set; }

        public IEnumerable<string> StructureList { get; set; }
    }
}
