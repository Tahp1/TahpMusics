using System.Linq;
namespace TahpMusic.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}