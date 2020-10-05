using CrossmamaNew.DAL.Entities;
using CrossmamaNew.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace CrossmamaNew.WEB.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly ICategoryRepository _categoryRepo;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepo = categoryRepository;
        }

        [HttpGet]
        [Route("api/categories")]
        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepo.Categories;
        }


        [HttpGet]
        [Route("api/categories/{sectionId}")]
        public IEnumerable<Category> GetCategories(int sectionId)
        {
            return _categoryRepo.GetCategories(sectionId);
        }

       
    }
}
