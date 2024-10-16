using E_Commerce.DtoLayer.CatalogDtos.ProductDtos;
using E_Commerce.WebUI.Services.CatalogServices.ProductServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace E_Commerce.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailFeatureViewComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductDetailFeatureViewComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var values = await _productService.GetByIdProductAsync(id);
            return View(values);
        }
    }
}
