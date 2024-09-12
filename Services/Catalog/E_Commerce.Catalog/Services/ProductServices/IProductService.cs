using E_Commerce.Catalog.Dtos.ProductDtos;

namespace E_Commerce.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductDtoAsync(CreateProductDto createProductDto);
        Task UpdateProductDtoAsync(UpdateProductDto updateProductDto);
        Task DeleteProductDtoAsync(string id);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
    }
}
