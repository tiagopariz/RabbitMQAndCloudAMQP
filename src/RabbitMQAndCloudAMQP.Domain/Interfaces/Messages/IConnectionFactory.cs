using System;

namespace RabbitMQAndCloudAMQP.Domain.Interfaces.Messages
{
    public interface IConnectionFactory
    {
        string Url { get; }
        Uri Uri { get; }
        IConnection CreateConnection();
    }
}