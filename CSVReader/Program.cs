using CsvDataAccess.CsvReading;
using CsvDataAccess.Interface;
using CsvDataAccess.Builder;
using System.Net.Cache;
using CSVReader;

string filePath = "sampleData.csv";
CsvData csvData = new CsvReader().Read(filePath);

ITableDataBuilder tableDataBuiler = new TableDataBuilder();
ITableData tableData = tableDataBuiler.Build(csvData);

// Console.WriteLine("The value in the scond column of 16th row is {0}.",tableData.GetValue("Col2", 14));
Console.WriteLine($"{tableData.RowCount} rows have been created.");

Console.WriteLine("Done. Press any key to close.");

Console.ReadKey();
