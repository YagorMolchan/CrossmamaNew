using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossmamaNew.DAL.Entities.ManyToMany;

namespace CrossmamaNew.DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? SectionId { get; set; }

        public Section Section { get; set; }

        public ICollection<Noun> Nouns { get; set; }

        public ICollection<Lot> Lots { get; set; }        


        public Category()
        {
            Nouns = new List<Noun>();
            Lots = new List<Lot>();
        }
    }


    //public enum T:String
    //{
    //    Monday="чсч",
    //    Tuesday="sda"
    //}
}
