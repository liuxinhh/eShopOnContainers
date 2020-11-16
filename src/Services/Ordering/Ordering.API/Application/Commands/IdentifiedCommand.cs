using MediatR;
using System;

namespace Microsoft.eShopOnContainers.Services.Ordering.API.Application.Commands
{
    /// <summary>
    /// 继承 IRequest 声明这是个事件类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="R"></typeparam>
    public class IdentifiedCommand<T, R> : IRequest<R>
        where T : IRequest<R>
    {
        public T Command { get; }
        public Guid Id { get; }
        public IdentifiedCommand(T command, Guid id)
        {
            Command = command;
            Id = id;
        }
    }
}
