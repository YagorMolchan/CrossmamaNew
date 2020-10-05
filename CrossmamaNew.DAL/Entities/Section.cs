using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities
{
    public class Section
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Category> Categories { get; set; }

        public Section()
        {
            Categories = new List<Category>();
        }
    }
}
