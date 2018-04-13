using RabbitMQAndCloudAMQP.Domain.Interfaces.Messages;

namespace RabbitMQAndCloudAMQP.Domain.Messages
{
    public abstract class MessageBase : IMessage
    {
        protected MessageBase(string body)
        {
            Body = body;
        }

        public string Body { get; }
    }
}