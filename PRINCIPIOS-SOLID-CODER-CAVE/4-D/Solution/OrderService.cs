using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._4_D.Solution
{
    internal class OrderService
    {
        public readonly IEventNotificationService _eventNotificationService;

        public OrderService(IEventNotificationService eventNotificationService)
        {
            _eventNotificationService = eventNotificationService;
        }

        public void GenerateOrder(Order order)
        {
            // TODO: code for create order

            // Send notification to datadog
            _eventNotificationService.LogEvent("The Order was sucessfully created");
        }
    }

    public class Order { }
}
