using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebStore.DAL.Context;
using WebStore.Domain.Entities.Identity;
using WebStore.Domain.Entities.Orders;
using WebStore.Sevices.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Sevices.InSQL
{
    public class SqlOrderService : IOrderService
    {
        private readonly WebStoreDB _db;
        private readonly UserManager<User> _UserManager;

        public SqlOrderService(WebStoreDB db, UserManager<User> UserManager)
        {
            _db = db;
            _UserManager = UserManager;
        }

        public async Task<IEnumerable<Order>> GetUserOrder(string User) { throw new System.NotImplementedException(); }

        public async Task<Order> GetOrderById(int id) { throw new System.NotImplementedException(); }

        public async Task<Order> CreateOrder(string User, CartViewModel Cart, OrderViewModel OrderModel) { throw new System.NotImplementedException(); }
    }
}
