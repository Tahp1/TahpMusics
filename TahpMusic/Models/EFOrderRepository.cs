using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace TahpMusic.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private TahpMusicDbContext context;
        public EFOrderRepository(TahpMusicDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders
        .Include(o => o.Lines)
        .ThenInclude(l => l.Music);
        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Music));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}