using RabbitMQAndCloudAMQP.Domain.Interfaces.Messages;

namespace RabbitMQAndCloudAMQP.Domain.Messages
{
    public class Channel : IChannel
    {
        public Channel(IQueue queue, string exchange, string routingKey)
        {
            Queue = queue;
            Exchange = exchange;
            RoutingKey = routingKey;
        }

        public IQueue Queue { get; }
        public string Exchange { get; }
        public string RoutingKey { get; }

        public void Publish(IMessage message)
        {
            throw new System.NotImplementedException();
        }
    }
}