namespace Builder.Domain.Reports
{
    public class SalesReportBuilder : IReportBuilder
    {
        private readonly SalesReport _report = new();

        public IReportBuilder WithTitle(string title)
        {
            _report.Title = title;
            return this;
        }

        public IReportBuilder ForPeriod(DateTime start, DateTime end)
        {
            _report.StartDate = start;
            _report.EndDate = end;
            return this;
        }

        public IReportBuilder AddColumn(string column)
        {
            _report.Columns.Add(column);
            return this;
        }

        public IReportBuilder AddFilter(string filter)
        {
            _report.Filters.Add(filter);
            return this;
        }

        public IReportBuilder WithTotals()
        {
            _report.IncludeTotals = true;
            return this;
        }

        public IReportBuilder Landscape()
        {
            _report.Orientation = "Landscape";
            return this;
        }

        public IReportBuilder Portrait()
        {
            _report.Orientation = "Portrait";
            return this;
        }

        public IReportBuilder WithWatermark(string watermark)
        {
            _report.WaterMark = watermark;
            return this;
        }

        public IReportBuilder WithPageNumbers()
        {
            _report.PageSize = _report.PageSize;
            return this;
        }

        public IReportBuilder ForPrinting()
        {
            _report.PageSize = PageType.A4.ToString();
            _report.Orientation = "Portrait";
            _report.IncludePageNumbers = true;
            return this;
        }

        public IReportBuilder ForDashboard()
        {
            _report.PageSize = PageType.A3.ToString();
            _report.Orientation = "Landscape";
            _report.IncludePageNumbers = false;
            _report.IncludeTotals = true;
            return this;
        }

        public SalesReport Build() => _report;
    }
}