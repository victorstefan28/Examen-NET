using Examen.Models.Dog.Dto;
using Examen.Services;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly IDogService _dogService;

        public DogController(IDogService dogService)
        {
            _dogService = dogService;
        }

        [HttpPost]
        public IActionResult CreateDog(DogDto dogDto)
        {
            var result = _dogService.CreateDogAsync(dogDto).Result;
            return result != null ? Ok(result) : BadRequest();
        }

        [HttpGet]
        public IActionResult GetAllDogs()
        {
            var result = _dogService.GetAllDogsAsync().Result;
            return result != null ? Ok(result) : BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult GetDogById(Guid id)
        {
            var result = _dogService.GetDogByIdAsync(id).Result;
            return result != null ? Ok(result) : BadRequest();
        }
    }
}
