using Domain;

namespace Application
{
    public interface IInventoryService
    {
        Task<IEnumerable<Mobile>> GetMobilesAsync();
    }
}
