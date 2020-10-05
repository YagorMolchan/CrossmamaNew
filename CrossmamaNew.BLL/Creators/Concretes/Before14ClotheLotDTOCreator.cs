using CrossmamaNew.BLL.Creators.Abstracts;
using CrossmamaNew.BLL.DTO.Abstracts;
using CrossmamaNew.BLL.DTO.Concrtetes;
using CrossmamaNew.DAL.Entities;
using CrossmamaNew.DAL.Entities.Sizes.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.BLL.Creators.Concretes
{
    public class Before14ClotheLotDTOCreator : LotDTOCreator
    {
        public override LotDTO Create(Lot lot)
        {
            var size = (Before14ClotheSize)lot.Size;


            var lotDTO = new Before14ClotheLotDTO
            {
                NownName = lot.Noun.Name,
                GenderName = lot.Gender.Name,
                StateName = lot.State.Name,
                StructureList = lot.LotStructures.Select(l => l.Structure.Name),
                ColorList = lot.LotColors.Select(l => l.Color.Name),
                Age = size.Age,
                Height = size.Height,
                SizeList = new string[] { size.Value, size.EUValue, size.UKValue, size.USAValue }
            };
            return lotDTO;
        }
    }
}
