using CrossmamaNew.DAL.Entities;
using CrossmamaNew.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrossmamaNew.WEB.Controllers
{
    public class ColorsController : ApiController
    {
        private readonly IColorRepository _colorRepo;

        public ColorsController(IColorRepository colorRepository)
        {
            _colorRepo = colorRepository;
        }

        [HttpGet]
        [Route("api/colors")]
        public IEnumerable<Color> GetColors()
        {
            return _colorRepo.Colors;
        }
    }
}
