using E_Commerce.DtoLayer.CatalogDtos.FeatureDtos;
using E_Commerce.WebUI.Services.CatalogServices.FeatureServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace E_Commerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Feature")]
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Öne Çıkan Alanlar";
            ViewBag.V3 = "Öne Çıkan Alan Listesi";
            ViewBag.v0 = "Öne Çıkan Alan İşlemleri";

            var values = await _featureService.GetAllFeatureAsync();
            return View(values);
        }
        [HttpGet]
        [Route("CreateFeature")]
        public IActionResult CreateFeature()
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Öne Çıkan Alanlar";
            ViewBag.V3 = "Yeni Öne Çıkan Alan";
            ViewBag.v0 = "Öne Çıkan Alan İşlemleri";
            return View();
        }
        [HttpPost]
        [Route("CreateFeature")]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            await _featureService.CreateFeatureAsync(createFeatureDto);
            return RedirectToAction("Index", "Feature", new { area = "Admin" });
        }
        [Route("DeleteFeature/{id}")]
        public async Task<IActionResult> DeleteFeature(string id)
        {
            await _featureService.DeleteFeatureAsync(id);
            return RedirectToAction("Index", "Feature", new { area = "Admin" });
        }
        [Route("UpdateFeature/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateFeature(string id)
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Öne Çıkan Alanlar";
            ViewBag.V3 = "Öne Çıkan Alan Güncelleme Sayfası";
            ViewBag.v0 = "Öne Çıkan Alan İşlemleri";
            var values = await _featureService.GetByIdFeatureAsync(id);
            return View(values);
        }
        [Route("UpdateFeature/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            await _featureService.UpdateFeatureAsync(updateFeatureDto);
            return RedirectToAction("Index", "Feature", new { area = "Admin" });
        }
    }
}
