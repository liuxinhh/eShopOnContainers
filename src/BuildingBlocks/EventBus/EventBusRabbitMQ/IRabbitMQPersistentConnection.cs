using RabbitMQ.Client;
using System;

namespace Microsoft.eShopOnContainers.BuildingBlocks.EventBusRabbitMQ
{
    /// <summary>
    /// RabbitMq 连接接口
    /// </summary>
    public interface IRabbitMQPersistentConnection
        : IDisposable
    {
        bool IsConnected { get; }

        bool TryConnect();

        IModel CreateModel();
    }
}
