using E_Commerce.DtoLayer.CatalogDtos.BrandDtos;
using E_Commerce.WebUI.Services.CatalogServices.BrandServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace E_Commerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Brand")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Markalar";
            ViewBag.V3 = "Marka Listesi";
            ViewBag.v0 = "Marka İşlemleri";

            var values = await _brandService.GetAllBrandAsync();
            return View(values);
        }
        [HttpGet]
        [Route("CreateBrand")]
        public IActionResult CreateBrand()
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Markalar";
            ViewBag.V3 = "Yeni Marka Girişi";
            ViewBag.v0 = "Marka İşlemleri";
            return View();
        }
        [HttpPost]
        [Route("CreateBrand")]
        public async Task<IActionResult> CreateBrand(CreateBrandDto createBrandDto)
        {
            await _brandService.CreateBrandAsync(createBrandDto);
            return RedirectToAction("Index", "Brand", new { area = "Admin" });
        }
        [Route("DeleteBrand/{id}")]
        public async Task<IActionResult> DeleteBrand(string id)
        {
            await _brandService.DeleteBrandAsync(id);
            return RedirectToAction("Index", "Brand", new { area = "Admin" });
        }
        [Route("UpdateBrand/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateBrand(string id)
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Markalar";
            ViewBag.V3 = "Marka Güncelleme Sayfası";
            ViewBag.v0 = "Marka İşlemleri";
            var values = await _brandService.GetByIdBrandAsync(id);
            return View(values);
        }
        [Route("UpdateBrand/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateBrand(UpdateBrandDto updateBrandDto)
        {
            await _brandService.UpdateBrandAsync(updateBrandDto);
            return RedirectToAction("Index", "Brand", new { area = "Admin" });
        }
    }
}
