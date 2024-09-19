using E_Commerce.DtoLayer.CatalogDtos.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace E_Commerce.WebUI.ViewComponents.ProductDetailViewComponents
{
    public class _ProductDetailFeatureViewComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProductDetailFeatureViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7060/api/Products/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
