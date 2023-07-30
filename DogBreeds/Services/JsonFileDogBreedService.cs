using DogBreeds.Models;
using System.Text.Json;

namespace DogBreeds.Services
{
    public class JsonFileDogBreedService
    {
        public JsonFileDogBreedService(IWebHostEnvironment webHostEnvironment)
        {

            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "dogs.json");

        public IEnumerable<Dogs> GetDogs()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);

            return JsonSerializer.Deserialize<Dogs[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })!;
        }
}
}
