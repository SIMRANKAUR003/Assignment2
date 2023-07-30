using System.Text.Json;
using System.Text.Json.Serialization;
namespace DogBreeds.Models
{
    public class Dogs
    {
        public int? Id { get; set; }
        public string? Breed { get; set; }

        public string? Fur { get; set; }

        public string? Fur_Color { get; set; }

        public string? Gender { get; set; }

        public int? Life_Expectancy { get; set; }

        public string? Image { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Dogs>(this);
    }
}
