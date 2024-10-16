using E_Commerce.DtoLayer.CatalogDtos.ProductDtos;
using E_Commerce.DtoLayer.CatalogDtos.ProductImageDtos;
using E_Commerce.WebUI.Services.CatalogServices.ProductImageServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace E_Commerce.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailImageViewComponentPartial : ViewComponent
    {
        private readonly IProductImageService _productImageService;

        public _ProductDetailImageViewComponentPartial(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {

            var values = await _productImageService.GetByProductIdProductImageAsync(id);
            return View(values);
        }
    }
}
