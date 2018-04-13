using RabbitMQ.Client;
using ConnectionFactoryBase = RabbitMQAndCloudAMQP.Domain.Messages.ConnectionFactoryBase;
using IConnection = RabbitMQAndCloudAMQP.Domain.Interfaces.Messages.IConnection;

namespace RabbitMQAndCloudAMQP.Domain.RabbitMQ
{
    public class Connection : ConnectionFactoryBase
    {
        private static readonly ConnectionFactory RabbitMqConnectionFactory = new ConnectionFactory();

        public Connection(string url)
            : base(url)
        {
            RabbitMqConnectionFactory.Uri = Uri;
        }

        public override IConnection CreateConnection()
        {
            var rabbitConnection = RabbitMqConnectionFactory.CreateConnection();
            IConnection connection = null;
            return connection;
        }
    }
}