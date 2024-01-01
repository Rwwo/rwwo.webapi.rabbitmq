using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using rwwo.webapi.rabbitmq.Models;
using System;
using System.Text;
using System.Text.Json;

const string EXCHANGE = "portifolio-rabbitmq";

var connectionFactory = new ConnectionFactory
{
    HostName = "localhost"
};

var connection = connectionFactory.CreateConnection("port-rabbitmq");

var consumerChannel = connection.CreateModel();

var consumer = new EventingBasicConsumer(consumerChannel);

consumer.Received += (sender, eventArgs) =>
{
    var contentArray = eventArgs.Body.ToArray();
    var contentString = Encoding.UTF8.GetString(contentArray);

    var message = JsonSerializer.Deserialize<Product>(contentString);

    Console.WriteLine($"Message received: {contentString}");

    consumerChannel.BasicAck(eventArgs.DeliveryTag, false);
};

consumerChannel.BasicConsume("product-created", false, consumer);

Console.ReadLine();
