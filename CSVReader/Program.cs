using CsvDataAccess.CsvReading;
using CsvDataAccess.Interface;
using CsvDataAccess.Builder;

string filePath = "sampleData.csv";
CsvData csvData = new CsvReader().Read(filePath);

ITableDataBuilder tableDataBuiler = new TableDataBuilder();
ITableData tableData = tableDataBuiler.Build(csvData);
Console.WriteLine($"{tableData.RowCount} rows have been created.");

Console.WriteLine("Done. Press any key to close.");
Console.ReadKey();
