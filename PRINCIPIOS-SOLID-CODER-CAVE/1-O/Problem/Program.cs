using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._1_O.Problem
{
    internal class Program
    {
        public static void Main()
        {
            List<Order> orders  = new List<Order>(); // Get orders from data source

            ReportingService service = new ReportingService();
            service.GenerateReport(orders, ReportType.PDF);
        }
    }
}
