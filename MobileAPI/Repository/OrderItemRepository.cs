using DataAccess.Repository.IRepository;
using MobileAPI.DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task<OrderItem> UpdateAsync(OrderItem entity)
        {
            _db.OrderItems.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
