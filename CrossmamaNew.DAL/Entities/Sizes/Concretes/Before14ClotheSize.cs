using CrossmamaNew.DAL.Entities.Sizes.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities.Sizes.Concretes
{
    public class Before14ClotheSize:Size
    {
        public string Age { get; set; }

        public string Height { get; set; }

        public string EUValue { get; set; }

        public string UKValue { get; set; }

        public string USAValue { get; set; }
    }
}
