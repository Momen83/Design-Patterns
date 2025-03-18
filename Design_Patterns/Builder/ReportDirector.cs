using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    public class ReportDirector
    {
        IReportBuilder _builder;

        public ReportDirector(IReportBuilder builder)
        {
            _builder = builder;
        }

        public Report BuildFullReport()
        {
            return _builder.SetTitle("Monthly Sales Report")
                           .SetSummary("This report provides an overview of sales for March.")
                           .SetBody("Total Sales: $50,000\nNumber of Transactions: 200\nTop Product: Wireless Headphones")
                           .SetFooter("Generated on: 2025-03-18\nCompany: ABC Corp.")
                           .Build();
        }

        public void replaceReportType(IReportBuilder builder)
        {
            _builder = builder;
        }
    }
}
