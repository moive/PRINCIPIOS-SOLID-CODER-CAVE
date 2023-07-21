using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._1_O.Solution
{
    internal class ReportingService
    {
        private readonly IReporGenerator _reportGenerator;

        public ReportingService(IReporGenerator reporGenerator)
        {
            _reportGenerator = reporGenerator;
        }

        public void GenerateReport(List<Order> orders)
        {
            _reportGenerator.CreateReport(orders);
        }
    }

    public class Order { }
}
