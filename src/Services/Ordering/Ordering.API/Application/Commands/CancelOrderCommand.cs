using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Ordering.API.Application.Commands
{
    public class CancelOrderCommand : IRequest<bool>
    {
        // todo [DataMember] 表示属性可以被序列化
        [DataMember]
        public int OrderNumber { get; private set; }
        public CancelOrderCommand()
        {

        }
        public CancelOrderCommand(int orderNumber)
        {
            OrderNumber = orderNumber;
        }
    }
}
