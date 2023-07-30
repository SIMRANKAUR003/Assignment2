using DogBreeds.Models;
using DogBreeds.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DogBreeds.Pages
{
    public class DogBreedsTableViewModel : PageModel
    {
            public JsonFileDogBreedService DogBreedService;

            public IEnumerable<Dogs> DogsData { get; private set; } = default!;


            public DogBreedsTableViewModel(ILogger<IndexModel> logger, JsonFileDogBreedService dogBreedService)
            {

                DogBreedService = dogBreedService;
            }

            public void OnGet()
            {

                DogsData = DogBreedService.GetDogs();
            }
    }
}
