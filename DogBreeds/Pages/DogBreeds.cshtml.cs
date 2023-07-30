using DogBreeds.Models;
using DogBreeds.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DogBreeds.Pages
{
    public class DogBreedsModel : PageModel
    {
        public JsonFileDogBreedService DogBreedService;

        public IEnumerable<Dogs> DogsData { get; private set; } = default!;


        public DogBreedsModel(ILogger<IndexModel> logger, JsonFileDogBreedService dogBreedService)
        {

            DogBreedService = dogBreedService;
        }

        public void OnGet()
        {

            DogsData = DogBreedService.GetDogs();
        }
    }
}
