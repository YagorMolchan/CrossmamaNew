using CrossmamaNew.DAL.Entities.ManyToMany;
using CrossmamaNew.DAL.Entities.Sizes.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities
{
    public class Lot
    {
        public int Id { get; set; }
        
        public string ImagePath { get; set; }


        //Gender

        public int? GenderId { get; set; }

        public Gender Gender { get; set; }

        //Category

        //public int? CategoryId { get; set; }

        //public Category Category { get; set; }

        //Noun
        public int? NounId { get; set; }

        public Noun Noun { get; set; }

        //Size

        public int? SizeId { get; set; }

        public Size Size { get; set; }

        ////Section
        //public int? SectionId { get; set; }

        //public Section Section { get; set; }

        //State

        public int? StateId { get; set; }

        public State State { get; set; }

        public ICollection<LotStructure> LotStructures { get; set; }

        public ICollection<LotColor> LotColors { get; set; }

        //Comment
        public string Comment { get; set; }


        public Lot()
        {
            LotColors = new List<LotColor>();
            LotStructures = new List<LotStructure>();
        }
    }
}
