# RabbitMQ Message Queue Using .NET Core 6 Web API

* Esse projeto � uma implementa��o b�sica de rabbitmq message queue usando .net core 6 como produtor de mensagens e uma aplica��o console como consumidora.

## Pr� Requisitos
* Visual Studio
* Docker Desktop
* .Net Core 6 SDK

## Introdu��o ao RabbitMQ
* O RabbitMQ � o corretor de mensagens que atua como uma middleware ao utilizar v�rios microsservi�os.
* O RabbitMQ � um software de corretor de mensagens de c�digo aberto. �s vezes, tamb�m � chamado de middleware orientado a mensagens.
* O RabbitMQ � escrito na linguagem de programa��o Erlang.
* O RabbitMQ � utilizado para reduzir a carga e o tempo de entrega de uma aplica��o web quando alguns recursos levam muito tempo para processar os dados.

## Benef�cios de usar RabbitMQ
H� muitos benef�cios em usar um Message Broker para enviar dados ao consumidor. Abaixo alguns exemplos:
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
