using RabbitMQAndCloudAMQP.Domain.Interfaces.Messages;
using System;

namespace RabbitMQAndCloudAMQP.Domain.Messages
{
    public class Connection : IConnection
    {
        public Connection(string url,
                          Uri uri)
        {
            Url = url;
            Uri = uri;
        }

        public string Url { get; }
        public Uri Uri { get; }
    }
}