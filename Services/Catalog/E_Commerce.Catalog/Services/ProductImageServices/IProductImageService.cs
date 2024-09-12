using E_Commerce.Catalog.Dtos.ProductImageDtos;

namespace E_Commerce.Catalog.Services.ProductImageImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GetAllProductImageAsync();
        Task CreateProductImageDtoAsync(CreateProductImageDto createProductImageDto);
        Task UpdateProductImageDtoAsync(UpdateProductImageDto updateProductImageDto);
        Task DeleteProductImageDtoAsync(string id);
        Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);
    }
}
