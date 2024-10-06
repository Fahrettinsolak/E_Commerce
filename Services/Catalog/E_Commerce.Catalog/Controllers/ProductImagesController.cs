using E_Commerce.Catalog.Dtos.ProductImageDtos;
using E_Commerce.Catalog.Services.ProductImageImageServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImageService _productImageService;

        public ProductImagesController(IProductImageService ProductImageService)
        {
            _productImageService = ProductImageService;
        }
        [HttpGet]
        public async Task<IActionResult> ProductImageList()
        {
            var values = await _productImageService.GetAllProductImageAsync();
            return Ok(values);
        }
        [HttpGet("ProductImagesByProductId")]
        public async Task<IActionResult> ProductImagesByProductId(string id)
        {
            var values = await _productImageService.GetByProductIdProductImageAsync(id);
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImageById(string id)
        {
            var value = await _productImageService.GetByIdProductImageAsync(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
        {
            await _productImageService.CreateProductImageDtoAsync(createProductImageDto);
            return Ok("Ürün Görselleri başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductImage(string id)
        {
            await _productImageService.DeleteProductImageDtoAsync(id);
            return Ok("Ürün Görselleri başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
        {
            await _productImageService.UpdateProductImageDtoAsync(updateProductImageDto);
            return Ok("Ürün Görselleri başarıyla güncellendi");
        }
    }
}
