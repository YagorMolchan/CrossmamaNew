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
    public class SectionsController : ApiController
    {
        private readonly ISectionRepository _sectionRepo;

        public SectionsController(ISectionRepository sectionRepository)
        {
            _sectionRepo = sectionRepository;
        }

        [HttpGet]
        [Route("api/sections")]
        public IEnumerable<Section> GetSections()
        {
            return _sectionRepo.Sections;
        }
    }
}
