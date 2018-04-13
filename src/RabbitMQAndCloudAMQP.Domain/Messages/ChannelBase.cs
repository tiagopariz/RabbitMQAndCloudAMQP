using RabbitMQAndCloudAMQP.Domain.Interfaces.Messages;

namespace RabbitMQAndCloudAMQP.Domain.Messages
{
    public abstract class ChannelBase : IChannel
    {
        protected ChannelBase(IQueue queue,
                              string exchange,
                              string routingKey)
        {
            Queue = queue;
            Exchange = exchange;
            RoutingKey = routingKey;
        }

        public IQueue Queue { get; }
        public string Exchange { get; }
        public string RoutingKey { get; }

        public virtual void Publish(IMessage message) { }
    }
}