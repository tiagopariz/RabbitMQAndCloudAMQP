using RabbitMQAndCloudAMQP.Domain.Interfaces.Messages;

namespace RabbitMQAndCloudAMQP.Domain.Messages
{
    public class Message : IMessage
    {
        public Message(string body)
        {
            Body = body;
        }

        public string Body { get; }
    }
}