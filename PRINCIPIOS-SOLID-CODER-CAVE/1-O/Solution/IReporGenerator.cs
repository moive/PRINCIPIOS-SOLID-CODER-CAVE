using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._1_O.Solution
{
    interface IReporGenerator
    {
        void CreateReport(List<Order> orders);
    }
}
