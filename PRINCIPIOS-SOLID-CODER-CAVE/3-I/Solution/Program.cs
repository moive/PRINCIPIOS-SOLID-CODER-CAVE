using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._3_I.Solution
{
    internal class Program
    {
        public static void Main()
        {
            BurgerOrderService service = new BurgerOrderService();
            service.OrderBurger(2);
        }
    }
}
