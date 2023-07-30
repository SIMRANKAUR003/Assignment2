using DogBreeds.Models;
using DogBreeds.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DogBreeds.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BreedsController : ControllerBase
    {
            public BreedsController(JsonFileDogBreedService dogBreedService)
            {
                this.DogBreedService = dogBreedService;
            }

            public JsonFileDogBreedService DogBreedService { get; }

            [HttpGet]
            public IEnumerable<Dogs> Get()
            {
                return DogBreedService.GetDogs(); ;
            }

       
        } // class
    } // namespace


