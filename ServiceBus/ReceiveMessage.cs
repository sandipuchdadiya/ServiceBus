﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;


namespace ServiceBus
{
    class ReceiveMessage
    {
        static void Main1(string[] args)
        {
            var connectionString = "Endpoint=sb://sb-learning.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=4mDaYzWg+LJsuaIL8coPVc9PTD6iv0O9Xtp90vX0dQo=";
            var queueName = "queuetest";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            var message = new BrokeredMessage("This is a test message!");

            Console.WriteLine(String.Format("Message id: {0}", message.MessageId));

            client.Send(message);

            Console.WriteLine("Message successfully sent! Press ENTER to exit program");
            Console.ReadLine();
        }
    }
}
