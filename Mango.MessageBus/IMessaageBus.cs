namespace Mango.MessageBus
{
    public interface IMessaageBus
    {
        Task PublishMessage(object message, string topic_queue_Name);
    }
}
