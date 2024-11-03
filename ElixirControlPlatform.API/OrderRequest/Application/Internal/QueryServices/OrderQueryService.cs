using ElixirControlPlatform.API.OrderRequest.Domain.Model.Aggregate;
using ElixirControlPlatform.API.OrderRequest.Domain.Model.Queries;
using ElixirControlPlatform.API.OrderRequest.Domain.Repositories;
using ElixirControlPlatform.API.OrderRequest.Domain.Services;

namespace ElixirControlPlatform.API.OrderRequest.Application.Internal.QueryServices;

public class OrderQueryService(IOrderRepository orderRepository) : IOrderQueryService
{
    public async Task<OrderRequests?> Handle(GetOrderByIdQuery query)
    {
        return await orderRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<OrderRequests>> Handle(GetAllOrdersQuery query)
    {
        return await orderRepository.ListAsync();
    }
}