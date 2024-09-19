using E_Commerce.DtoLayer.CatalogDtos.AboutDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace E_Commerce.WebUI.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    [Route("Admin/About")]
    public class AboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Hakkımızda";
            ViewBag.V3 = "Hakkımızda Listesi";
            ViewBag.v0 = "Hakkımızda İşlemleri";

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7060/api/Abouts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                return View(values);
            }

            return View();
        }
        [HttpGet]
        [Route("CreateAbout")]
        public IActionResult CreateAbout()
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Hakkımızda";
            ViewBag.V3 = "Yeni Hakkımızda Sayfası";
            ViewBag.v0 = "Hakkımızda İşlemleri";
            return View();
        }
        [HttpPost]
        [Route("CreateAbout")]
        public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createAboutDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7060/api/Abouts", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "About", new { area = "Admin" });
            }
            return View();
        }
        [Route("DeleteAbout/{id}")]
        public async Task<IActionResult> DeleteAbout(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7060/api/Abouts?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "About", new { area = "Admin" });
            }
            return View();
        }
        [Route("UpdateAbout/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateAbout(string id)
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Hakkımızda";
            ViewBag.V3 = "Hakkımızda Güncelleme Sayfası";
            ViewBag.v0 = "Hakkımızda İşlemleri";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7060/api/Abouts/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateAboutDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [Route("UpdateAbout/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateAboutDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7060/api/Abouts/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "About", new { area = "Admin" });
            }
            return View();
        }
    }
}
