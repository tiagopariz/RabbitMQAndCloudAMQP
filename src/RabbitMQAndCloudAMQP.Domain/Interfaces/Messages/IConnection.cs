using System;

namespace RabbitMQAndCloudAMQP.Domain.Interfaces.Messages
{
    public interface IConnection
    {
        string Url { get; }
        Uri Uri { get; }
    }
}