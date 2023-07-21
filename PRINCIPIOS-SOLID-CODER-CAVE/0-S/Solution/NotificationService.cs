using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._0_S.Solution
{
    interface INotificationService
    {
        bool EmailInvoice(Invoice invoice);
    }
    class NotificationService : INotificationService
    {
        public bool EmailInvoice(Invoice invoice)
        {
            // Code to email Invoice
            return true;
        }
    }
}
