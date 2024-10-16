﻿using E_Commerce.DtoLayer.CatalogDtos.FeatureSliderDtos;
using E_Commerce.WebUI.Services.CatalogServices.FeatureSliderServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace E_Commerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/FeatureSlider")]
    public class FeatureSliderController : Controller
    {
        private readonly IFeatureSliderService _featureSliderService;

        public FeatureSliderController(IFeatureSliderService featureSliderService)
        {
            _featureSliderService = featureSliderService;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Öne Çıkan Görseller";
            ViewBag.V3 = "Öne Çıkan Görsel Listesi";
            ViewBag.v0 = "Öne Çıkan Görsel Slider İşlemleri";

            var values = await _featureSliderService.GetAllFeatureSliderAsync();
            return View(values);
        }
        [HttpGet]
        [Route("CreateFeatureSlider")]
        public IActionResult CreateFeatureSlider()
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Öne Çıkan Görseller";
            ViewBag.V3 = "Yeni Öne Çıkan Görsel ";
            ViewBag.v0 = "Öne Çıkan Görsel Slider İşlemleri";
            return View();
        }
        [HttpPost]
        [Route("CreateFeatureSlider")]
        public async Task<IActionResult> CreateFeatureSlider(CreateFeatureSliderDto createFeatureSliderDto)
        {
            await _featureSliderService.CreateFeatureSliderAsync(createFeatureSliderDto);
            return RedirectToAction("Index", "FeatureSlider", new { area = "Admin" });
        }
        [Route("DeleteFeatureSlider/{id}")]
        public async Task<IActionResult> DeleteFeatureSlider(string id)
        {
            await _featureSliderService.DeleteFeatureSliderAsync(id);
            return RedirectToAction("Index", "FeatureSlider", new { area = "Admin" });
        }
        [Route("UpdateFeatureSlider/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateFeatureSlider(string id)
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Öne Çıkan Görseller";
            ViewBag.V3 = "Öne Çıkan Görsel Güncelleme Sayfası ";
            ViewBag.v0 = "Öne Çıkan Görsel Slider İşlemleri";
            var values = await _featureSliderService.GetByIdFeatureSliderAsync(id);
            return View(values);
        }
        [Route("UpdateFeatureSlider/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateFeatureSlider(UpdateFeatureSliderDto updateFeatureSliderDto)
        {
            await _featureSliderService.UpdateFeatureSliderAsync(updateFeatureSliderDto);
            return RedirectToAction("Index", "FeatureSlider", new { area = "Admin" });

        }
    }
}
