namespace Builder.Domain.Reports
{
    public class SalesReport
    {
        public string Title { get; set; } = string.Empty;
        public string Format { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string HeaderText { get; set; } = string.Empty;
        public string FooterText { get; set; } = string.Empty;
        public string ChartType { get; set; } = string.Empty;
        public List<string> Columns { get; set; } = [];
        public List<string> Filters { get; set; } = [];
        public string SortBy { get; set; } = string.Empty;
        public string GroupBy { get; set; } = string.Empty;
        public bool IncludeTotals { get; set; }
        public string Orientation { get; set; } = string.Empty;
        public string PageSize { get; set; } = string.Empty;
        public bool IncludePageNumbers { get; set; }
        public string CompanyLogo { get; set; } = string.Empty;
        public string WaterMark { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Report '{Title}' " +
                   $"[{StartDate:dd/MM/yyyy} - {EndDate:dd/MM/yyyy}] " +
                   $"GroupBy:{(string.IsNullOrEmpty(GroupBy) ? "-" : GroupBy)} " +
                   $"SortBy:{(string.IsNullOrEmpty(SortBy) ? "-" : SortBy)} " +
                   $"Totals:{(IncludeTotals ? "Yes" : "No")} " +
                   $"Page:{PageSize}-{Orientation}";
        }
    }
}