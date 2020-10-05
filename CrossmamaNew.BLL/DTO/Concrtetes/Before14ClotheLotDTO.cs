using CrossmamaNew.BLL.DTO.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.BLL.DTO.Concrtetes
{
    public class Before14ClotheLotDTO:LotDTO
    {
        public string Age { get; set; }

        public string Height { get; set; }

        public string[] SizeList { get; set; }
    }
}
