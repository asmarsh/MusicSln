using System.Linq;

namespace MusicStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}