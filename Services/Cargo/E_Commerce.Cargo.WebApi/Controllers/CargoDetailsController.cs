using E_Commerce.Cargo.BusinessLayer.Abstract;
using E_Commerce.Cargo.DtoLayer.Dtos.CargoDetailDtos;
using E_Commerce.Cargo.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailsController(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }
        [HttpGet]
        public IActionResult CargoDetailList()
        {
            var values = _cargoDetailService.TGetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoDetailById(int id)
        {
            var value = _cargoDetailService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
        {
            CargoDetail cargoDetail = new CargoDetail()
            {
                Barcode = createCargoDetailDto.Barcode,
                CargoCompanyId = createCargoDetailDto.CargoCompanyId,
                ReciverCustomer = createCargoDetailDto.ReciverCustomer,
                SenderCustomer = createCargoDetailDto.SenderCustomer
            };

            _cargoDetailService.TInsert(cargoDetail);
            return Ok("Kargo Detayları Ekleme İşlemi Başarıyla Yapıldı.");
        }
        [HttpPut]
        public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
        {
            CargoDetail cargoDetail = new CargoDetail()
            {
                Barcode = updateCargoDetailDto.Barcode,
                CargoCompanyId = updateCargoDetailDto.CargoCompanyId,
                ReciverCustomer = updateCargoDetailDto.ReciverCustomer,
                SenderCustomer = updateCargoDetailDto.SenderCustomer,
                CargoDetailId = updateCargoDetailDto.CargoDetailId
            };
            _cargoDetailService.TUpdate(cargoDetail);
            return Ok("Kargo Detayları Güncelleme İşlemi Başarıyla Yapıldı.");
        }
        [HttpDelete]
        public IActionResult RemoveCargoDetail(int id)
        {
            _cargoDetailService.TDelete(id);
            return Ok("Kargo Detayları Silme İşlemi Başarıyla Yapıldı.");
        }

    }
}
