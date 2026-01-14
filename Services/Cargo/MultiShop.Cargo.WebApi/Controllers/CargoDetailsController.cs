using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multihop.Cargo.EntityLayer.Concrete;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoDetailsDtos;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoCompanyService;

        public CargoDetailsController(ICargoDetailService cargoCompanyService)
        {
            _cargoCompanyService = cargoCompanyService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _cargoCompanyService.GetAll();
            return Ok(result);
        }

        [HttpPost]

        public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
        {
            CargoDetail cargoCompany = new CargoDetail()
            {
                Barcode = createCargoDetailDto.Barcode,
                CargoCompanyId = createCargoDetailDto.CargoCompanyId,
                ReceiverCustomer = createCargoDetailDto.ReceiverCustomer,
                SenderCustomer = createCargoDetailDto.SenderCustomer
            };

            _cargoCompanyService.Insert(cargoCompany);
            return Ok("Kargo Detayları Başarı ile Oluşturuldu");
        }
            
        [HttpPut]
        public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
        {
            CargoDetail cargoCompany = new CargoDetail()
            {
                Barcode = updateCargoDetailDto.Barcode,
                CargoCompanyId= updateCargoDetailDto.CargoCompanyId,
                CargoDetailId= updateCargoDetailDto.CargoDetailId,
                ReceiverCustomer = updateCargoDetailDto.ReceiverCustomer,
                SenderCustomer = updateCargoDetailDto.SenderCustomer
            };
            _cargoCompanyService.Update(cargoCompany);
            return Ok("Kargo Detayları Başarıyla Güncellendi");
        }

        public IActionResult RemoveCargoDetail(int id)
        {
            _cargoCompanyService.Delete(id);
            return Ok("Kargo Detayları Başarıyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoDetailById(int id)
        {
            var result = _cargoCompanyService.GetById(id);
            return Ok(result);
        }
}
