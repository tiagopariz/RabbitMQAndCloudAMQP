using RabbitMQAndCloudAMQP.Domain.Interfaces.Messages;
using System;

namespace RabbitMQAndCloudAMQP.Domain.Messages
{
    public abstract class ConnectionFactoryBase : IConnectionFactory
    {
        protected ConnectionFactoryBase(string url)
        {
            Url = url;
        }

        public string Url { get; }
        public Uri Uri => new Uri(Url.Replace("amqp://", "amqps://"));

        public abstract IConnection CreateConnection();
    }
}