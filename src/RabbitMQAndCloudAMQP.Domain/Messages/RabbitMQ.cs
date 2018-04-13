using RabbitMQ.Client;
using RabbitMQAndCloudAMQP.Domain.RabbitMQ;
using System;
using System.Text;

namespace RabbitMQAndCloudAMQP.Domain.Messages
{
    public class RabbitMq
    {
        // CloudAMQP URL in format amqp://user:pass@hostName:port/vhost
        private static readonly string Url = "amqp://fjmbtlqc:rYbxR3SbqAmMuw8tf1NE_nTJp_ELrIW-@hornet.rmq.cloudamqp.com/fjmbtlqc"; //ConfigurationManager.AppSettings["CLOUDAMQP_URL"];
        // Create a ConnectionFactory and set the Uri to the CloudAMQP url
        // the connectionfactory is stateless and can safetly be a static resource in your app
        private static readonly ConnectionFactory ConnFactory = new ConnectionFactory();
        private const bool Durable = true;
        private const bool Exclusive = false;
        private const bool AutoDelete = false;

        public RabbitMq()
        {
            var conn = new Connection(
                url: "amqp://fjmbtlqc:rYbxR3SbqAmMuw8tf1NE_nTJp_ELrIW-@hornet.rmq.cloudamqp.com/fjmbtlqc"
            );
        }

        public object Publish(string message, string queueName = "person")
        {
            Console.WriteLine("Conectando...");
            // create a connection and open a channel, dispose them when done
            using (var conn = ConnFactory.CreateConnection())
            {
                Console.WriteLine("Conectado.");
                using (var channel = conn.CreateModel())
                {
                    // the data put on the queue must be a byte array
                    var data = Encoding.UTF8.GetBytes(message);
                    // ensure that the queue exists before we publish to it
                    channel.QueueDeclare(queueName, Durable, Exclusive, AutoDelete, null);
                    // publish to the "default exchange", with the queue name as the routing key
                    var exchangeName = "";
                    var routingKey = queueName;
                    channel.BasicPublish(exchangeName, routingKey, null, data);
                }
            }
            return message;
        }

        public string Get(string queueName = "person")
        {
            Console.WriteLine("Conectando");
            using (var conn = ConnFactory.CreateConnection())
            {
                Console.WriteLine("Conectado.");
                using (var channel = conn.CreateModel())
                {
                    // ensure that the queue exists before we access it
                    channel.QueueDeclare(queueName, Durable, Exclusive, AutoDelete, null);
                    // do a simple poll of the queue
                    var data = channel.BasicGet(queueName, false);
                    // the message is null if the queue was empty
                    if (data == null) return null;
                    // convert the message back from byte[] to a string
                    var message = Encoding.UTF8.GetString(data.Body);
                    // ack the message, ie. confirm that we have processed it
                    // otherwise it will be requeued a bit later
                    channel.BasicAck(data.DeliveryTag, false);
                    return message;
                }
            }
        }

    }
}