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
    public class After14ClotheLotDTOCreator : LotDTOCreator
    {
        public override LotDTO Create(Lot lot)
        {
            var size = (After14ClotheSize)lot.Size;
            string koeff = null;

            if (lot.GenderId == 1)
            {
                koeff = size.MValue;
            }
            if (lot.GenderId == 2)
            {
                koeff = size.FValue;
            }


            var lotDTO = new After14ClotheLotDTO
            {
                NownName = lot.Noun.Name,
                GenderName = lot.Gender.Name,
                StateName = lot.State.Name,
                SizeList = new string[] { koeff, size.Value },
                ColorList = lot.LotColors.Select(l => l.Color.Name),
                StructureList = lot.LotStructures.Select(l => l.Structure.Name)
            };
            return lotDTO;
        }
    }
}
