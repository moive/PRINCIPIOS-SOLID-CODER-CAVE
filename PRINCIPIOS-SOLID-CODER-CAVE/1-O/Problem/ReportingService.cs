using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._1_O.Problem
{
    internal class ReportingService
    {
        public void GenerateReport(List<Order> orders, ReportType type)
        {
            // Generic code to create report
            // Specific conversion depending on type

            if (type == ReportType.PDF)
            {
                CreatePDFReport(orders);
            }
            else if (type == ReportType.EXCEL)
            {
                CreateExcelReport(orders);
            }
        }

        public void CreatePDFReport(List<Order> orders)
        {
            // Create PDF Report
        }

        public void CreateExcelReport(List<Order> orders)
        {
            // Create Excel Report
        }
    }

    class Order { }

    class ReportType
    {
        internal static readonly ReportType EXCEL;
        internal static ReportType PDF;

    }
}
