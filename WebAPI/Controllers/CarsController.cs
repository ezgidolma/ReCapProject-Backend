using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
         _carService = carService;
        }


        [HttpGet("getall")]
        public IActionResult Get()
        {
            
            var result= _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
      
        [HttpGet("getbybrand")]
        public IActionResult GetByBrand(int brandId)
        {
            var result = _carService.GetAllByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycolor")]
        public IActionResult GetByColor(int colorId)
        {
            var result = _carService.GetAllByColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getCarDetails")]
        public IActionResult GetCarlDetail()
        {
            var result = _carService.GetCarDetails();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetsByCarId")]
        public IActionResult GetCarDetailsByCarId(int carId)
        {
            var result = _carService.GetByCarId(carId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();

        }

        [HttpGet("getCarDetailsByColorAndByBrand")]
        public IActionResult GetCarDetailsByColorAndByBrand(int colorId, int brandId)
        {

            var result = _carService.GetCarDetailsByColorAndByBrand(colorId, brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

    }
}
