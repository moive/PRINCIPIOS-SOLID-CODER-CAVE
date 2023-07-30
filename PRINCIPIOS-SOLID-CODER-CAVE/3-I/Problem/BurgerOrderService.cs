using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._3_I.Problem
{
    internal class BurgerOrderService : IFoodOrderService
    {
        public void OrderBurger(int quantity)
        {
            // Code to order a Burger
        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException("Can't order a salad from this service");
        }

        public void OrderSteak(int quantity)
        {
            throw new NotImplementedException("Can't order a steak from this service");
        }

    }
}
