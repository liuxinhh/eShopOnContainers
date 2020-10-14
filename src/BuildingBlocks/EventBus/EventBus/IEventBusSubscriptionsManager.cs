using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;
using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;
using System;
using System.Collections.Generic;
using static Microsoft.eShopOnContainers.BuildingBlocks.EventBus.InMemoryEventBusSubscriptionsManager;

namespace Microsoft.eShopOnContainers.BuildingBlocks.EventBus
{
    /// <summary>
    /// 领域事件订阅管理器 接口
    /// IEventBusSubscriptionsManager
    /// </summary>
    public interface IEventBusSubscriptionsManager
    {
        bool IsEmpty { get; }

        /// <summary>
        /// 移除事件
        /// </summary>
        event EventHandler<string> OnEventRemoved;
        void AddDynamicSubscription<TH>(string eventName)
           where TH : IDynamicIntegrationEventHandler;

        /// <summary>
        /// 添加订阅
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TH"></typeparam>
        void AddSubscription<T, TH>()
           where T : IntegrationEvent
           where TH : IIntegrationEventHandler<T>;

        /// <summary>
        /// 取消订阅
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TH"></typeparam>
        void RemoveSubscription<T, TH>()
             where TH : IIntegrationEventHandler<T>
             where T : IntegrationEvent;

        /// <summary>
        /// 取消订阅
        /// </summary>
        /// <typeparam name="TH"></typeparam>
        /// <param name="eventName">事件名称</param>
        void RemoveDynamicSubscription<TH>(string eventName)
            where TH : IDynamicIntegrationEventHandler;

        /// <summary>
        /// 检查是否订阅消息事件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool HasSubscriptionsForEvent<T>() where T : IntegrationEvent;

        /// <summary>
        /// 检查是否订阅消息事件
        /// </summary>
        /// <param name="eventName">消息事件名称</param>
        /// <returns></returns>
        bool HasSubscriptionsForEvent(string eventName);

        /// <summary>
        /// 获取事件类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Type GetEventTypeByName(string eventName);

        /// <summary>
        /// 清除
        /// </summary>
        void Clear();

        /// <summary>
        /// 获取集成事件集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IEnumerable<SubscriptionInfo> GetHandlersForEvent<T>() where T : IntegrationEvent;

        /// <summary>
        /// 获取集成事件集合
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <returns></returns>
        IEnumerable<SubscriptionInfo> GetHandlersForEvent(string eventName);

        string GetEventKey<T>();
    }
}