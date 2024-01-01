namespace rwwo.webapi.rabbitmq.RabbitMQ
{
    public interface IRabbitMQProducer
    {
        void Publish<T>(string routingKey, T message);
    }
}
