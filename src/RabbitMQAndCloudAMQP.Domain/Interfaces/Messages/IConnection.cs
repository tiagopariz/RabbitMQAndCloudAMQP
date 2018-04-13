namespace RabbitMQAndCloudAMQP.Domain.Interfaces.Messages
{
    public interface IConnection
    {
        IChannel CreateModel();
    }
}
