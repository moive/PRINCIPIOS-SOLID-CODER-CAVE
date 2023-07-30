using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._3_I.Problem
{
    internal interface IFoodOrderService
    {
        void OrderBurger(int quantity);

        void OrderSteak(int quantity);

        void OrderSalad(int quantity);
    }
}
