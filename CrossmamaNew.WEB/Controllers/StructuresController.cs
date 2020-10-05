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
    public class StructuresController : ApiController
    {
        private readonly IStructureRepository _structureRepo;

        public StructuresController(IStructureRepository structureRepository)
        {
            _structureRepo = structureRepository;
        }

        [HttpGet]
        [Route("api/structures")]
        public IEnumerable<Structure> GetStructures()
        {
            return _structureRepo.Structures;
        }
    }
}
