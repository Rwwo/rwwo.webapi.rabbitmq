# RabbitMQ Message Queue Using .NET Core 6 Web API

* Esse projeto é uma implementação básica de rabbitmq message queue usando .net core 6 como produtor de mensagens e uma aplicação console como consumidora.

## Pré Requisitos
* Visual Studio
* Docker Desktop
* .Net Core 6 SDK

## Introdução ao RabbitMQ
* O RabbitMQ é o corretor de mensagens que atua como uma middleware ao utilizar vários microsserviços.
* O RabbitMQ é um software de corretor de mensagens de código aberto. Às vezes, também é chamado de middleware orientado a mensagens.
* O RabbitMQ é escrito na linguagem de programação Erlang.
* O RabbitMQ é utilizado para reduzir a carga e o tempo de entrega de uma aplicação web quando alguns recursos levam muito tempo para processar os dados.

## Benefícios de usar RabbitMQ
Há muitos benefícios em usar um Message Broker para enviar dados ao consumidor. Abaixo alguns exemplos:
* Alta Disponibilidade
* Escalabilidade

## Docker Desktop
Para nossos testes, precisamos de um container rodando.

```
docker pull rabbitmq:3-management
docker run --rm -it -p 15672:15672 -p 5672:5672 rabbitmq:3-management

```


> [!NOTE]
> Esse projeto foi desenvolvido apenas para fins de aprendizado
