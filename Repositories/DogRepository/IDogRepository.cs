using Examen.Models.Dog;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.DogRepository
{
    public interface IDogRepository : IGenericRepository<Dog>
    {
        Task<Dog> getDogByIdAsync(Guid id);
    }
}
