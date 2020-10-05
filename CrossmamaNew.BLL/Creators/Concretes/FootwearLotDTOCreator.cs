using CrossmamaNew.BLL.Creators.Abstracts;
using CrossmamaNew.BLL.DTO.Abstracts;
using CrossmamaNew.BLL.DTO.Concrtetes;
using CrossmamaNew.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.BLL.Creators.Concretes
{
    public class FootwearLotDTOCreator : LotDTOCreator
    {
        public override LotDTO Create(Lot lot)
        {
            var lotDTO = new FootwearLotDTO
            {
                NownName=lot.Noun.Name,
                GenderName=lot.Gender.Name,
                StateName=lot.State.Name,
                SizeValue=lot.Size.Value,
                ColorList=lot.LotColors.Select(l => l.Color.Name),
                StructureList=lot.LotStructures.Select(l => l.Structure.Name)
            };
            return lotDTO;
        }
    }
}
