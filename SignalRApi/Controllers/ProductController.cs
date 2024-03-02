﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinnesLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.ProductDto;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);

        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new EntityLayer.Entities.Product()
            {
                ProductName = createProductDto.ProductName,
                Description = createProductDto.Description,
                Price = createProductDto.Price,
                ImageUrl = createProductDto.ImageUrl,
                ProductStatus = createProductDto.ProductStatus

            });
            return Ok("Product Eklendi");

        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var values = _productService.TGetByID(id);
            _productService.TDelete(values);
            return Ok("Product Bilgisi silindi");

        }

        [HttpGet("GetProducxt")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.TGetByID(id);
            return Ok(values);

        }

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new EntityLayer.Entities.Product()
            {
                Productid = updateProductDto.Productid,
                ProductName = updateProductDto.ProductName,
                Description = updateProductDto.Description,
                Price = updateProductDto.Price,
                ImageUrl = updateProductDto.ImageUrl,
                ProductStatus = updateProductDto.ProductStatus

            });
            return Ok("Product Güncellendi");

        }
    }
}
