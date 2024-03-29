﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinnesLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("Get_list")]
        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(value);

        }
        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
			
			return Ok(_categoryService.TCategoryCount()); // TCategoryCount() method is not implemented in ICategoryService interface.

		}
        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_categoryService.TActiveCategoryCount());
        }

        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            return Ok(_categoryService.TPassiveCategoryCount());
        }


        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.TAdd(new EntityLayer.Entities.Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                Status = true
            }) ;
            return Ok("Kategori Eklendi");


        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var values = _categoryService.TGetByID(id);
            _categoryService.TDelete(values);
            return Ok("Kategori silindi");

        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var values = _categoryService.TGetByID(id);
            return Ok(values);

        }
        
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.TUpdate(new EntityLayer.Entities.Category()
            {
                CategoryName = updateCategoryDto.CategoryName,
                Categoryid = updateCategoryDto.Categoryid,
                Status = updateCategoryDto.Status
            });
            return Ok("Kategori Güncellendi");


        }
    }
}
