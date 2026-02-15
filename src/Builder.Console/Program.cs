using Builder.Domain.Reports;

var director = new SalesReportDirector();
var builder = new SalesReportBuilder();

//Apresentation
var apresentation = director.PrintApresentation(builder);
Console.WriteLine(apresentation.ToString() + "\n");

//Simple
var simple = director.PrintSimple(builder);
Console.WriteLine(simple.ToString() + "\n");

//Complete
var complete = director.PrintComplete(builder);
Console.WriteLine(complete.ToString() + "\n");