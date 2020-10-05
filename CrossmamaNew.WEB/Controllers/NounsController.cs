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
    public class NounsController : ApiController
    {
        private readonly INounRepository _nounRepo;

        public NounsController(INounRepository nounRepository)
        {
            _nounRepo = nounRepository;
        }

        [HttpGet]
        [Route("api/nouns/{categoryId}")]
        public IEnumerable<Noun> GetNouns(int categoryId)
        {
            return _nounRepo.GetNouns(categoryId);
        }
    }
}
