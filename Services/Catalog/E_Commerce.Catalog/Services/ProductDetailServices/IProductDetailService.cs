using E_Commerce.Catalog.Dtos.ProductDetailDtos;

namespace E_Commerce.Catalog.Services.ProductDetailDetailServices
{
    public interface IProductDetailService
    {
        Task<List<ResultProductDetailDto>> GetAllProductDetailAsync();
        Task CreateProductDetailDtoAsync(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductDetailDtoAsync(UpdateProductDetailDto updateProductDetailDto);
        Task DeleteProductDetailDtoAsync(string id);
        Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(string id);
        Task<GetByIdProductDetailDto> GetByProductIdProductDetailAsync(string id);
    }
}
