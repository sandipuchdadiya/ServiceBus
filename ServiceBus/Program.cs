using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;


namespace ServiceBus
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Endpoint=sb://sb-learning.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=4mDaYzWg+LJsuaIL8coPVc9PTD6iv0O9Xtp90vX0dQo=";
            var queueName = "queuetest";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);

            client.OnMessage(message =>
            {
                Console.WriteLine(String.Format("Message body: {0}", message.GetBody<String>()));
                Console.WriteLine(String.Format("Message id: {0}", message.MessageId));
            });

            Console.WriteLine("Press ENTER to exit program");
            Console.ReadLine();
        }
    }
}
