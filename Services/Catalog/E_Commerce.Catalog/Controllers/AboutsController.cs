﻿using E_Commerce.Catalog.Dtos.AboutDtos;
using E_Commerce.Catalog.Services.AboutServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        public AboutsController(IAboutService AboutService)
        {
            _aboutService = AboutService;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _aboutService.GetAllAboutAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutById(string id)
        {
            var values = await _aboutService.GetByIdAboutAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
        {
            await _aboutService.CreateAboutAsync(createAboutDto);
            return Ok("Hakkımızda başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(string id)
        {
            await _aboutService.DeleteAboutAsync(id);
            return Ok("Hakkımızda başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            await _aboutService.UpdateAboutAsync(updateAboutDto);
            return Ok("Hakkımızda başarıyla güncellendi");
        }
    }
}
