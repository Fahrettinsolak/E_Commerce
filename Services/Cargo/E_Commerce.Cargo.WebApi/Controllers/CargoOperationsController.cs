using E_Commerce.Cargo.BusinessLayer.Abstract;
using E_Commerce.Cargo.DtoLayer.Dtos.CargoOperationDtos;
using E_Commerce.Cargo.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoOperationsController : ControllerBase
    {
        private readonly ICargoOperationService _cargoOperationService;

        public CargoOperationsController(ICargoOperationService cargoOperationService)
        {
            _cargoOperationService = cargoOperationService;
        }
        [HttpGet]
        public IActionResult CargoOperationList()
        {
            var values = _cargoOperationService.TGetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoOperationById(int id)
        {
            var value = _cargoOperationService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCargoOperation(CreateCargoOperationDto createCargoOperationDto)
        {
            CargoOperation cargoOperation = new CargoOperation()
            {
                Barcode = createCargoOperationDto.Barcode,
                Description = createCargoOperationDto.Description,
                OperationDate = createCargoOperationDto.OperationDate
            };

            _cargoOperationService.TInsert(cargoOperation);
            return Ok("Kargo İşlemi Ekleme İşlemi Başarıyla Yapıldı.");
        }
        [HttpPut]
        public IActionResult UpdateCargoOperation(UpdateCargoOperationDto updateCargoOperationDto)
        {
            CargoOperation cargoOperation = new CargoOperation()
            {
                Barcode = updateCargoOperationDto.Barcode,
                CargoOperationId = updateCargoOperationDto.CargoOperationId,
                Description = updateCargoOperationDto.Description,
                OperationDate = updateCargoOperationDto.OperationDate
            };
            _cargoOperationService.TUpdate(cargoOperation);
            return Ok("Kargo İşlemi Güncelleme İşlemi Başarıyla Yapıldı.");
        }
        [HttpDelete]
        public IActionResult RemoveCargoOperation(int id)
        {
            _cargoOperationService.TDelete(id);
            return Ok("Kargo İşlemi Silme İşlemi Başarıyla Yapıldı.");
        }
    }
}
