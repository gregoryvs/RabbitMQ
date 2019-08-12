using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace RabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory();
            factory.UserName = "user";
            factory.Password = "fiap";
            factory.HostName = "23.99.218.43";

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
             
                byte[] body = Encoding.UTF8.GetBytes("Oi");

                channel.BasicPublish(exchange: "fila1",
                    routingKey: "teste",
                    basicProperties: null,
                    body);
            }                
            Console.WriteLine("RabbitMQ!");
        }

        public void Imp1()
        { 
}
    }
}
