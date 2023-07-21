using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._0_S.Problem
{
    internal class OrderService
    {
        public void SaveOrder(Order order)
        {
            try
            {
                this.InsertOrder(order);

                var invoice = this.CreateInvoice(order);

                this.EmailInvoice(invoice);

                File.WriteAllText(@"e:\InfoLog.txt", "The order has been complete");

            }
            catch (Exception e)
            {
                File.WriteAllText(@"e:\ErrorLog.txt", e.Message);
            }
        }

        public bool InsertOrder(Order order)
        {
            // Code to Insert the Order on the database
            return true;
        }

        public Invoice CreateInvoice(Order order)
        {
            // Code to Create Invoice
            return new Invoice();
        }

        public bool EmailInvoice(Invoice invoice)
        {
            // Code to email Invoice
            return true;
        }
    }

    public class Order { }

    public class Invoice { }
}
