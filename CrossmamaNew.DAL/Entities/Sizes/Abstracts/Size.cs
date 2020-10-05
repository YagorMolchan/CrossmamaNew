using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities.Sizes.Abstracts
{
    public abstract class Size
    {
        public int Id { get; set; }

        public string Value { get; set; }
    }
}
