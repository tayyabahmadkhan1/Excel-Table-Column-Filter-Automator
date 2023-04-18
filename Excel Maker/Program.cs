using OfficeOpenXml;
using OfficeOpenXml.Filter;
using System.IO;

ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
using var excelPackage = new ExcelPackage();

var worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
worksheet.Cells["A1"].Value = "Name";
worksheet.Cells["B1"].Value = "Age";
worksheet.Cells["A2"].Value = "John Doe";
worksheet.Cells["B2"].Value = 30;
worksheet.Cells["A3"].Value = "Michael Clarke";
worksheet.Cells["B3"].Value = 40;
worksheet.Cells["A4"].Value = "James Marting";
worksheet.Cells["B4"].Value = 50;

var range = worksheet.Cells["A1:B4"];
var table = worksheet.Tables.Add(range, "Table1");

worksheet.Cells["A1:B4"].AutoFilter = true;

var file = new FileInfo(@"C:\Users\Tayyab\Desktop\C# EF\Excel Maker\file3.xlsx");
excelPackage.SaveAs(file);