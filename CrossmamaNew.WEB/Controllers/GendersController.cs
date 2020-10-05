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
    public class GendersController : ApiController
    {
        private readonly IGenderRepository _genderRepo;

        public GendersController(IGenderRepository genderRepository)
        {
            _genderRepo = genderRepository;
        }

        [HttpGet]
        [Route("api/genders")]
        public IHttpActionResult GetGenders()
        {
            return Ok(_genderRepo.Genders);
        }
    }
}
