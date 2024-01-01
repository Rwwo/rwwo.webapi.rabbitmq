using System.Text.Json;
using RabbitMQ.Client;
using System.Text;

namespace rwwo.webapi.rabbitmq.RabbitMQ
{
    public class RabbitMQProducer : IRabbitMQProducer
    {
        private readonly IModel _channel;
        const string EXCHANGE = "portifolio-rabbitmq";

        public RabbitMQProducer()
        {
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };

            var connection = connectionFactory.CreateConnection("port-rabbitmq");

            _channel = connection.CreateModel();
        }

        public void Publish<T>(string routingKey, T message)
        {
            var json = JsonSerializer.Serialize(message);

            var byteArray = Encoding.UTF8.GetBytes(json);

            _channel.BasicPublish(EXCHANGE, routingKey, null, byteArray);
        }
    }
}
