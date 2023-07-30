using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._4_D.Problem
{
    public class DataDogService
    {
        public void LogEvent(string message)
        {
            // Code to event on DataDog
        }
    }

    internal class OrderService
    {
        public readonly DataDogService _dataDogService;

        public OrderService(DataDogService dataDogService)
        {
            _dataDogService = dataDogService;
        }

        public void GenerateOrder(Order order)
        {
            // TODO: Code for create order

            // Send notification to datalog
            _dataDogService.LogEvent("The Order was successfully created");
        }
    }

    public class Order { }
}