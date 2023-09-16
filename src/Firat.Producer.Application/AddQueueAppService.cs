
using RabbitMQ.Client;
using System;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Firat.Producer
{
    public class AddQueueAppService:ApplicationService, IAddQueueAppService
    {

        public AddQueueAppService()
        {
           
        }
        public virtual async Task Queue() {
            ConnectionFactory factory = new ConnectionFactory();
            //factory.Uri = new Uri("amqp://hkhjerrt:hcqiavAqll6-co4abXnSqUBh_hHifz-Z@hornet.rmq.cloudamqp.com/hkhjerrt");
            factory.HostName = "localhost";

            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare("mesajkuyrugu", false, false, false);
                byte[] bytemessage = Encoding.UTF8.GetBytes("sebepsiz boş yere ayrılacaksan");
                channel.BasicPublish(exchange: "", routingKey: "mesajkuyrugu", body: bytemessage);
            }

        }
    }
}
