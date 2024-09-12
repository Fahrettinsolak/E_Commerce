using E_Commerce.Catalog.Dtos.CategoryDtos;

namespace E_Commerce.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryDtoAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryDtoAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryDtoAsync(string id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
    }
}
