using Microsoft.eShopOnContainers.Services.Ordering.Domain.Seedwork;
using System.Threading.Tasks;

namespace Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.OrderAggregate
{
    // 这仅仅是在领域层RepositoryContracts或接口定义
    // 作为订单聚合的必要条件

    public interface IOrderRepository : IRepository<Order>
    {
        Order Add(Order order);
        
        void Update(Order order);

        Task<Order> GetAsync(int orderId);
    }
}
