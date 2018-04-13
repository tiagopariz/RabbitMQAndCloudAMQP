using RabbitMQAndCloudAMQP.Domain.Messages;

namespace RabbitMQAndCloudAMQP.Domain.RabbitMQ
{
    public class Message : MessageBase
    {
        public Message(string body)
            : base(body)
        {
        }
    }
}