using E_Commerce.Catalog.Dtos.ProductImageDtos;
using E_Commerce.Catalog.Services.ProductImageImageServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImageService _ProductImageService;

        public ProductImagesController(IProductImageService ProductImageService)
        {
            _ProductImageService = ProductImageService;
        }
        [HttpGet]
        public async Task<IActionResult> ProductImageList()
        {
            var values = await _ProductImageService.GetAllProductImageAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImageById(string id)
        {
            var value = await _ProductImageService.GetByIdProductImageAsync(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
        {
            await _ProductImageService.CreateProductImageDtoAsync(createProductImageDto);
            return Ok("Ürün Görselleri başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductImage(string id)
        {
            await _ProductImageService.DeleteProductImageDtoAsync(id);
            return Ok("Ürün Görselleri başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
        {
            await _ProductImageService.UpdateProductImageDtoAsync(updateProductImageDto);
            return Ok("Ürün Görselleri başarıyla güncellendi");
        }
    }
}
