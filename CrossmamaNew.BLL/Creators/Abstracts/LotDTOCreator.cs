using CrossmamaNew.BLL.DTO.Abstracts;
using CrossmamaNew.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.BLL.Creators.Abstracts
{
    public abstract class LotDTOCreator
    {
        public abstract LotDTO Create(Lot lot);
    }
}
