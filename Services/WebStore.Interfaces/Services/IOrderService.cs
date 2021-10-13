using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Domain.Entities.Orders;
using WebStore.Domain.ViewModels;

namespace WebStore.Interfaces.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetUserOrder(string User);

        Task<Order> GetOrderById(int id);

        Task<Order> CreateOrder(string User, CartViewModel Cart, OrderViewModel OrderModel);
    }
}
