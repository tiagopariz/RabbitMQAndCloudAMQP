namespace RabbitMQAndCloudAMQP.Domain.Interfaces.Messages
{
    public interface IChannel
    {
        IQueue Queue { get; }
        string Exchange { get; }
        string RoutingKey { get; }

        void Publish(IMessage message);
    }
}