using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._0_S.Solution
{
    interface IOrderRepository
    {
        public bool InsertOrder(Order order);
    }

    class OrderRepository : IOrderRepository
    {
        public bool InsertOrder(Order order)
        {
            // Code to Insert the Order on the database
            return true;
        }
    }
}
