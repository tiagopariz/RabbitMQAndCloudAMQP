using RabbitMQAndCloudAMQP.Domain.Messages;
using System;

namespace RabbitMQAndCloudAMQP.Prompt
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("RabbitMQ and CloudAMQP");
            //var rmqSend = new RabbitMq();
            //Console.WriteLine(rmqSend.Publish("Tiago Pariz | " + DateTime.Now));

            var rmqRead = new RabbitMq();
            Console.WriteLine(rmqRead.Get());

            Console.ReadKey();
        }
    }
}