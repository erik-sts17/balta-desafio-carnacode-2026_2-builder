namespace Builder.Domain.Reports
{
    public class SalesReportDirector
    {
        public SalesReport PrintApresentation(IReportBuilder builder)
        {
            return builder
                  .WithTitle("Apresentation Report Mode")
                  .ForPrinting()
                  .WithWatermark("LogoCompany.png")
                  .WithPageNumbers()
                  .Build();
        }

        public SalesReport PrintComplete(IReportBuilder builder)
        {
            return builder
                  .WithTitle("Complete Report")
                  .ForPeriod(DateTime.MinValue, DateTime.Now)
                  .AddColumn("Total Sales")
                  .AddColumn("Total Profit")
                  .WithTotals()
                  .Landscape()
                  .WithWatermark("LogoFull.png")
                  .WithPageNumbers()
                  .ForPrinting()
                  .Build();
        }

        public SalesReport PrintSimple(IReportBuilder builder)
        {
            return builder
                  .WithTitle("Simple Report")
                  .ForDashboard()
                  .Build();
        }

        public SalesReport BuildAnnualSales(IReportBuilder builder)
        {
            return builder
                  .WithTitle("Annual Sales")
                  .ForPeriod(new DateTime(2024, 1, 1), new DateTime(2024, 12, 31))
                  .WithTitle("Sales Report")
                  .AddColumn("Product")
                  .AddColumn("Quantity")
                  .AddColumn("Value")
                  .WithTotals()
                  .Landscape()
                  .ForPrinting()
                  .Build();
        }
    }
}
