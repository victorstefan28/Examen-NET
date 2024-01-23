using Examen.Models.Dog;
using Examen.Models.Dog.Dto;

namespace Examen.Services
{
    public interface IDogService
    {
        Task<IEnumerable<DogDto>> GetAllDogsAsync();
        Task<Dog> CreateDogAsync(DogDto dogDto);

        Task<DogDto> GetDogByIdAsync(Guid id);

    }
}
