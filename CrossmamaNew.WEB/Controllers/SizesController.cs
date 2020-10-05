using CrossmamaNew.DAL.Entities.Sizes.Abstracts;
using CrossmamaNew.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrossmamaNew.WEB.Controllers
{
    public class SizesController : ApiController
    {
        private readonly ISizeRepository _sizeRepo;

        public SizesController(ISizeRepository sizeRepo)
        {
            _sizeRepo = sizeRepo;
        }

        //public IEnumerable<Size> GetBefore14Sizes()
        //{

        //}

    }
}
