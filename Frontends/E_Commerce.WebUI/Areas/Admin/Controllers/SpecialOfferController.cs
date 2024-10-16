using E_Commerce.DtoLayer.CatalogDtos.SpecialOfferDtos;
using E_Commerce.WebUI.Services.CatalogServices.SpecialOfferServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace E_Commerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/SpecialOffer")]
    public class SpecialOfferController : Controller
    {
        private readonly ISpecialOfferService _specialOfferService;

        public SpecialOfferController(ISpecialOfferService specialOfferService)
        {
            _specialOfferService = specialOfferService;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Özel Teklifler";
            ViewBag.V3 = "Özel Teklif Ve Günün İndirimi Listesi";
            ViewBag.v0 = "Özel Teklif İşlemleri";

            var values = await _specialOfferService.GettAllSpecialOfferAsync();
            return View(values);
        }
        [HttpGet]
        [Route("CreateSpecialOffer")]
        public IActionResult CreateSpecialOffer()
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Özel Teklifler";
            ViewBag.V3 = "Yeni Özel Teklif Ve Günün İndirimi Girişi";
            ViewBag.v0 = "Özel Teklif İşlemleri";
            return View();
        }
        [HttpPost]
        [Route("CreateSpecialOffer")]
        public async Task<IActionResult> CreateSpecialOffer(CreateSpecialOfferDto createSpecialOfferDto)
        {
            await _specialOfferService.CreateSpecialOfferAsync(createSpecialOfferDto);
            return RedirectToAction("Index", "SpecialOffer", new { area = "Admin" });
        }
        [Route("DeleteSpecialOffer/{id}")]
        public async Task<IActionResult> DeleteSpecialOffer(string id)
        {
            await _specialOfferService.DeleteSpecialOfferAsync(id);
            return RedirectToAction("Index", "SpecialOffer", new { area = "Admin" });
        }
        [Route("UpdateSpecialOffer/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateSpecialOffer(string id)
        {
            ViewBag.V1 = "Ana Sayfa";
            ViewBag.V2 = "Özel Teklifler";
            ViewBag.V3 = "Özel Teklif Ve Günün İndirimi Güncelleme Sayfası";
            ViewBag.v0 = "Özel Teklif İşlemleri";

            var values = await _specialOfferService.GetByIdSpecialOfferAsync(id);
            return View(values);
        }
        [Route("UpdateSpecialOffer/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateSpecialOffer(UpdateSpecialOfferDto updateSpecialOfferDto)
        {
            await _specialOfferService.UpdateSpecialOfferAsync(updateSpecialOfferDto);
            return RedirectToAction("Index", "SpecialOffer", new { area = "Admin" });
        }
    }
}
