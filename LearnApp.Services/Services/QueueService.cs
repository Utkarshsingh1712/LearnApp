using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Services.Services
{
    public class QueueService
    {
        private readonly ILogger<QueueService> _logger;
        public QueueService(ILogger<QueueService> logger)
        {
            _logger = logger;
        }

        public async Task SendMessage(string message)
        {
            ServiceBusClient client = null;
            ServiceBusClient sender=null;
            try
            {
                client = new ServiceBusClient("connection string");
                sender = client.CreateSender("QueueName");
                await sender.SendMessageAsync(message);
            }
            catch (Exception ex)
            {
                _logger.LogError("error",ex);
            }
        }
    }
}
