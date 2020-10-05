using CrossmamaNew.BLL.Creators.Concretes;
using CrossmamaNew.BLL.DTO.Abstracts;
using CrossmamaNew.DAL.Entities;
using CrossmamaNew.DAL.Entities.ManyToMany;
using CrossmamaNew.DAL.Entities.Sizes.Concretes;
using CrossmamaNew.DAL.Interfaces;
using CrossmamaNew.WEB.Models;
using CrossmamaNew.WEB.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace CrossmamaNew.WEB.Controllers
{
    public class LotsController : ApiController
    {
        private readonly ILotRepository _lotRepo;
        private readonly INounRepository _nounRepo;
        private readonly IGenderRepository _genderRepo;
        private readonly ISizeRepository _sizeRepo;
        private readonly IStateRepository _stateRepo;
        private readonly IColorRepository _colorRepo;
        private readonly IStructureRepository _structureRepo;

        public LotsController(ILotRepository lotRepository, INounRepository nounRepository, IGenderRepository genderRepository, ISizeRepository sizeRepository, IStateRepository stateRepository, IColorRepository colorRepository, IStructureRepository structureRepository)
        {
            _lotRepo = lotRepository;
            _nounRepo = nounRepository;
            _genderRepo = genderRepository;
            _sizeRepo = sizeRepository;
            _stateRepo = stateRepository;
            _colorRepo = colorRepository;
            _structureRepo = structureRepository;
        }

        [HttpGet]        
        public IEnumerable<Lot> GetLots([FromUri] PagingParameterModel pagingParameterModel)
        {
            var source = _lotRepo.Lots;
            var items = GetPagedLots(source, pagingParameterModel);
            return items;
        }

        [HttpGet]       
        public IEnumerable<Lot> GetLots(int genderId, [FromUri] PagingParameterModel pagingParameterModel)
        {
            var source = _lotRepo.GetLots(genderId);
            var items = GetPagedLots(source, pagingParameterModel);
            return items;
        }

        [HttpGet]
        public IEnumerable<Lot> GetClothes([FromUri] PagingParameterModel pagingParameterModel)
        {
            var source = _lotRepo.GetClothes();
            var items = GetPagedLots(source, pagingParameterModel);
            return items;
        }

        [HttpGet]
        public IEnumerable<Lot> GetClothes(int nounId, [FromUri] PagingParameterModel pagingParameterModel)
        {
            var source = _lotRepo.GetClothes(nounId);
            var items = GetPagedLots(source, pagingParameterModel);
            return items;
        }

        [HttpGet]
        public IEnumerable<Lot> GetFootwear([FromUri] PagingParameterModel pagingParameterModel)
        {
            var source = _lotRepo.GetFootwear();
            var items = GetPagedLots(source, pagingParameterModel);
            return items;
        }

        [HttpGet]
        public IEnumerable<Lot> GetFootwear(int nounId, [FromUri] PagingParameterModel pagingParameterModel)
        {
            var source = _lotRepo.GetFootwear(nounId);
            var items = GetPagedLots(source, pagingParameterModel);
            return items;
        }

        [HttpGet]
        public LotDTO GetLot(int id)
        {
            var lot = _lotRepo.GetLot(id);

            if(lot.Size is Before14ClotheSize)
            {
                return new Before14ClotheLotDTOCreator().Create(lot);
            }
            if(lot.Size is After14ClotheSize)
            {
                return new After14ClotheLotDTOCreator().Create(lot);
            }
            else if (lot.Size is FootwearSize)
            {
                return new FootwearLotDTOCreator().Create(lot);
            }
            return null;
        }

        

        //adding lot
        [HttpPost]
        [Authorize]
        public IHttpActionResult PostLot(LotBindingModel model)
        {
            string fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
            string extension = Path.GetExtension(model.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssffff") + extension;
            model.ImageFile.SaveAs(fileName);

            if (ModelState.IsValid)
            {
                var lot = new Lot
                {
                    ImagePath = "~/Images/" + fileName,
                    Noun = _nounRepo.GetNoun(model.NownName),
                    Gender = _genderRepo.GetGender(model.GenderName),
                    Size = _sizeRepo.GetSize(model.SizeValue),
                    State = _stateRepo.GetState(model.StateName),
                    Comment = model.Comment
                };

                foreach(var item in model.ColorList)
                {
                    lot.LotColors.Add(new LotColor { Color = _colorRepo.GetColor(item) });
                }

                foreach(var item in model.StructureList)
                {
                    lot.LotStructures.Add(new LotStructure { Structure = _structureRepo.GetStructure(item) });
                }

                return CreatedAtRoute("DefaultApi", new { id = lot.Id }, lot);

            }
            else
            {
                return BadRequest(ModelState);
            }
            
        }



        private IEnumerable<Lot> GetPagedLots(IEnumerable<Lot> source, [FromUri] PagingParameterModel pagingParameterModel)
        {
            int totalCount = source.Count();

            int currentPage = pagingParameterModel.PageNumber;

            int pageSize = pagingParameterModel.PageSize;

            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            var items = source.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            var previousPage = currentPage > 1 ? "Yes" : "No";

            var nextPage = currentPage < totalPages ? "Yes" : "No";

            var paginationMetadata = new
            {
                totalCount = totalCount,
                pageSize = pageSize,
                currentPage = currentPage,
                totalPages = totalPages,
                previousPage,
                nextPage
            };

            HttpContext.Current.Response.Headers.Add("Paging-Headers", JsonConvert.SerializeObject(paginationMetadata));
            return items;
        }
    }
}
