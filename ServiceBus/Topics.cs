using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;


namespace ServiceBus
{
    class Topics
    {
        static void Main(string[] args)
        {
            var connectionString = "##";
            var topicName = "NewTopic";

            var client = SubscriptionClient.CreateFromConnectionString(connectionString, topicName, "TopicSubscription");         

            client.OnMessage(message =>
            {
                Console.WriteLine(String.Format("Message body: {0}", message.GetBody<String>()));
                Console.WriteLine(String.Format("Message id: {0}", message.MessageId));
            });

            Console.WriteLine("Message successfully sent! Press ENTER to exit program");
            Console.ReadLine();
        }
    }
}
