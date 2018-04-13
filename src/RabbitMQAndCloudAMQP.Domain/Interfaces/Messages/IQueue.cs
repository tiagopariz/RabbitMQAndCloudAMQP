namespace RabbitMQAndCloudAMQP.Domain.Interfaces.Messages
{
    public interface IQueue
    {
        string Name { get; }
        bool Durable { get; }
        bool Exclusive { get; }
        bool AutoDelete { get; }
    }
}