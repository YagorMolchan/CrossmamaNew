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
    public class StatesController : ApiController
    {
        private readonly IStateRepository _stateRepo;

        public StatesController(IStateRepository stateRepository)
        {
            _stateRepo = stateRepository;
        }

        [HttpGet]
        [Route("api/states")]
        public IEnumerable<State> GetStates()
        {
            return _stateRepo.States;
        }
    }
}
