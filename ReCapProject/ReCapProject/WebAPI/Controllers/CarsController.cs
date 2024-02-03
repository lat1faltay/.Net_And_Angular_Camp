using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        // Test Edildi Hata Yok 
        // Eklenecek feature'lar
        // Araba eklendiği zaman araba başarıyla eklendi mesajı, eklenemediğinde hata mesajı
        // silindiğinde hata ve başarı mesajı
        // Arabalar listelendi, arabalar listelenemedi mesajı
        // istenilen id'de araba yok mesajı

        // Dependency Injection
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost("add")]
        public IActionResult Add(Car car) 
        {
            var result = _carService.Add(car);
            if (result.Success) 
            { 
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car) 
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult update(Car car) 
        { 
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }


        [HttpGet("getall")]
        public IActionResult Getall() 
        { 
            var result = _carService.GetAll();
            if (result.Success) 
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id) 
        { 

            var result = _carService.GetById(id);

            if (result.Success)
            {
                return Ok(result.Data); // Veri başarılıysa result.Data olarak dönmeli
            }
            return BadRequest(result.Message); // Başarısızsa hata mesajını 
        }
    }
}
