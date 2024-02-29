using Azure.Messaging.ServiceBus;

namespace Mango.MessageBus
{
    public class MessageBus : IMessaageBus
    {
        private string connectionString = string.Empty;
        public async Task PublishMessage(object message, string topic_queue_Name)
        {
            await using var client = new ServiceBusClient(connectionString);
        }
    }
}
