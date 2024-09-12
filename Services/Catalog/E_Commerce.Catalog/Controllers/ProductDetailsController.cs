using E_Commerce.Catalog.Dtos.ProductDetailDtos;
using E_Commerce.Catalog.Services.ProductDetailDetailServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailService _ProductDetailService;

        public ProductDetailsController(IProductDetailService ProductDetailService)
        {
            _ProductDetailService = ProductDetailService;
        }
        [HttpGet]
        public async Task<IActionResult> ProductDetailList()
        {
            var values = await _ProductDetailService.GetAllProductDetailAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductDetailById(string id)
        {
            var value = await _ProductDetailService.GetByIdProductDetailAsync(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductDetail(CreateProductDetailDto createProductDetailDto)
        {
            await _ProductDetailService.CreateProductDetailDtoAsync(createProductDetailDto);
            return Ok("Ürün Detayı başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductDetail(string id)
        {
            await _ProductDetailService.DeleteProductDetailDtoAsync(id);
            return Ok("Ürün Detayı başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto)
        {
            await _ProductDetailService.UpdateProductDetailDtoAsync(updateProductDetailDto);
            return Ok("Ürün Detayı başarıyla güncellendi");
        }
    }
}
