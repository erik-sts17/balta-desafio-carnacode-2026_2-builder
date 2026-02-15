namespace Builder.Domain.Reports
{
    public interface IReportBuilder
    {
        IReportBuilder WithTitle(string title);
        IReportBuilder ForPeriod(DateTime start, DateTime end);
        IReportBuilder AddColumn(string column);
        IReportBuilder AddFilter(string filter);
        IReportBuilder WithTotals();
        IReportBuilder Landscape();
        IReportBuilder Portrait();
        IReportBuilder WithWatermark(string watermark);
        IReportBuilder WithPageNumbers();
        IReportBuilder ForPrinting();
        IReportBuilder ForDashboard();
        SalesReport Build();
    }
}