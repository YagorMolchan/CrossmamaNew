using CrossmamaNew.DAL.Entities.Sizes.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Interfaces
{
    public interface ISizeRepository
    {
        Size GetSize(string value);
        IEnumerable<Size> GetBefore14ClotheSizes();
        IEnumerable<Size> GetAfter14ClotheSizes();
        IEnumerable<Size> GetFootwear();

    }
}
