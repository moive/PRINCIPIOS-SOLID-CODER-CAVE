using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._0_S.Solution
{
    interface IInvoiceService
    {
        Invoice CreateInvoice(Order order);
    }
    class InvoiceService : IInvoiceService
    {
        public Invoice CreateInvoice(Order order)
        {
            return new Invoice();
        }
    }
}
