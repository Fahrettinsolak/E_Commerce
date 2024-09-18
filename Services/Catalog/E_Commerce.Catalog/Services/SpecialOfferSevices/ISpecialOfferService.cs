using E_Commerce.Catalog.Dtos.SpecialOfferDtos;

namespace E_Commerce.Catalog.Services.SpecialOfferSevices
{
    public interface ISpecialOfferService
    {
        Task<List<ResultSpecialOfferDto>> GettAllSpecialOfferAsync();
        Task CreateSpecialOfferAsync(CreateSpecialOfferDto createSpecialOfferDto);
        Task UpdateSpecialOfferAsync(UpdateSpecialOfferDto updateSpecialOfferDto);
        Task DeleteSpecialOfferAsync(string id);
        Task<GetByIdSpecialOfferDto> GetByIdSpecialOfferAsync(string id);
    }
}
