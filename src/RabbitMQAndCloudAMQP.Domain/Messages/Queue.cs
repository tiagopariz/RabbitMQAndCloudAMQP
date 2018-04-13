using RabbitMQAndCloudAMQP.Domain.Interfaces.Messages;

namespace RabbitMQAndCloudAMQP.Domain.Messages
{
    public class Queue : IQueue
    {
        public Queue(string name,
                     bool durable,
                     bool exclusive,
                     bool autoDelete)
        {
            Name = name;
            Durable = durable;
            Exclusive = exclusive;
            AutoDelete = autoDelete;
        }

        public string Name { get; }
        public bool Durable { get; }
        public bool Exclusive { get; }
        public bool AutoDelete { get; }
    }
}