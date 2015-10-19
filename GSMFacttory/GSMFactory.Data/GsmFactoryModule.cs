namespace GsmFactory.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    // using GsmFactory.Common;
    using GsmFactory.Data.Contracts;
    using GsmFactory.Data.ReportProcessors;
    //using GsmFactory.Excel;
    //using GsmFactory.Json;
    using GsmFactory.Models;
    using GsmFactory.MongoDb;
    using GsmFactory.MongoDb.Contracts;
    using GsmFactory.MongoDb.Mapping;
    //using GsmFactory.Pdf;
    //using GsmFactory.Reports.Models;
    //using GsmFactory.XML;

    public class GsmFactoryModule
    {
        private readonly IGsmFactoryData gsmFactoryData = new GsmFactoryData();
        private readonly IMongDbContext  mongoDbContext = new MongoDbContext();
        // private readonly ReportQueries reportQueries;
        private readonly ILogger logger;

        public GsmFactoryModule(ILogger logger)
        {
            this.logger = logger;
           //  this.reportQueries = new ReportQueries(this.gsmFactoryData);
        }

        public void ReadFromMongoDb()
        {
            try
            {
                var mongoDbSeeder = new MongoDbSeeder(this.gsmFactoryData, this.mongoDbContext);
                mongoDbSeeder.Seed();

                this.logger.ShowMessage("Data from MongoDB Cloud Database was successfully seeded in SQL Server...");
            }
            catch (Exception)
            {
                this.logger.ShowMessage("Error! Cannot read data from MongoDb Cloud Database...");
            }
        }

        //public void ReadSaleReportsFromExcel(string selectedPath)
        //{
        //    try
        //    {
        //        var zipFileProcessor = new ZipFileProcessor();
        //        zipFileProcessor.Extract(selectedPath, Constants.ExtractedExcelReportsPath);

        //        var matchedDirectories = Utility.GetDirectoriesByPattern(Constants.ExtractedExcelReportsPath);
        //        this.ParseExcelDataAndExportItInSqlServer(matchedDirectories);

        //        this.logger.ShowMessage("Sales reports from Excel files were successfully imported to MSSQL...");
        //    }
        //    catch (Exception)
        //    {
        //        this.logger.ShowMessage("Error! Cannot extract and import sales report data from Excel files...");
        //    }
        //}

        //public void ReadAdditionalInformation(string selectedPath)
        //{
        //    try
        //    {
        //        var expensesFactory = new ExpensesReportFactoryFromXmlData(gsmFactoryData.Manufacturers);
        //        var xmlReader = new XmlDataReader();
        //        var xmlData = xmlReader.ReadXmlReportsData(Constants.XmlFilePath);
        //        this.AddExpensesReportsDataToMSSqlAndMongoDb(xmlData, expensesFactory);

        //        this.logger.ShowMessage("Additional info from Xml was successfully added to MSSQL Server and MongoDb Cloud Database...");
        //    }
        //    catch (Exception)
        //    {
        //        this.logger.ShowMessage("Error! Cannot export additional information from XML file to MSSQL Server and MongoDb...");
        //    }
        //}
 
        //public void ExportAggregatedSalesReportToPdf(Tuple<string, string> selectedPathAndFileName, DateTime startDate, DateTime endDate)
        //{
        //    try
        //    {
        //        var pdfData = this.reportQueries.GetPdfSaleReportsFromDatabase(startDate, endDate);
        //        var salesReportToPdfFactory = new PdfExportFactoryFromMsSqlDatabase(pdfData);
        //        salesReportToPdfFactory.ExportSalesEntriesToPdf(selectedPathAndFileName.Item1, selectedPathAndFileName.Item2, startDate, endDate);
        //        this.logger.ShowMessage("Sales Report was successfully exported to PDF...");
        //    }
        //    catch (Exception)
        //    {
        //        this.logger.ShowMessage("Error! Cannot export sales reports to Pdf file...");
        //    }
        //}

        //public void GenerateXmlReport(Tuple<string, string> selectedPathAndFileName, DateTime startDate, DateTime endDate)
        //{
        //    try
        //    {
        //        var xmlData = this.reportQueries.GetXmlSaleReportsFromDatabase(startDate, endDate);
        //        var xmlGenerator = new XmlReportGenerator(xmlData);
        //        xmlGenerator.CreateXmlReport(selectedPathAndFileName.Item1, selectedPathAndFileName.Item2, startDate, endDate);

        //        this.logger.ShowMessage("Sales reports were successfully exported as XML file...");
        //    }
        //    catch (Exception)
        //    {
        //        this.logger.ShowMessage("Error! Cannot export reports as XML file...");
        //    }
        //}

        //public void GenerateJsonReportsAndSaveThemToDisk(string folderPath)
        //{
        //    try
        //    {
        //        var jsonProductsReportsEntries = this.reportQueries.GetJsonProductsReportsFromDatabase();
        //        var productReportsToJsonFactory = new JsonReportsFactoryFromMsSqlDatabase(jsonProductsReportsEntries);
        //        productReportsToJsonFactory.SaveJsonProductsReportsToDisk(folderPath);
        //        this.logger.ShowMessage("Json reports were successfully saved to disk...");
        //    }
        //    catch (Exception)
        //    {
        //        this.logger.ShowMessage("Error! Cannot export JSON reports or save them to disk...");
        //    }
        //}

        //public void GenerateJsonReportsAndExportThemToMySql()
        //{
        //    try
        //    {
        //        var jsonProductsReportsEntries = this.reportQueries.GetJsonProductsReportsFromDatabase();
        //        var productReportsToJsonFactory = new JsonReportsFactoryFromMsSqlDatabase(jsonProductsReportsEntries);
        //        productReportsToJsonFactory.ExportJsonProductsReportsToMySqlDatabase();
        //        this.logger.ShowMessage("Json reports were successfully exported to MySql database...");
        //    }
        //    catch (Exception)
        //    {
        //        this.logger.ShowMessage("Error! Cannot export JSON reports to MySQL Database...");
        //    }
        //}

        //public void WriteReportToExcel(Tuple<string, string> selectedPathAndFileName)
        //{
        //    var repo = new ExcelSaleReportWriter();
        //    repo.GenerateExcelReport(selectedPathAndFileName.Item1, selectedPathAndFileName.Item2);
        //    try
        //    {
            

        //        this.logger.ShowMessage("Excel Report successfully created..");
        //    }
        //    catch (Exception)
        //    {
        //        this.logger.ShowMessage("Error! Cannot create Excel report...");
        //    }
        //}

        //private void AddExpensesReportsDataToMSSqlAndMongoDb(IList<XmlVendorExpenseEntry> xmlData, ExpensesReportFactoryFromXmlData expensesFactory)
        //{
        //    foreach (var expenseLog in xmlData)
        //    {
        //        var storeExpenseReport = expensesFactory.CreateStoreExpensesReport(expenseLog);
        //        gsmFactoryData.Expenses.Add(storeExpenseReport);
        //        this.mongoDbContext.ManufacturerExpenses.Insert(new ProduserExpenseMap()
        //        {
        //            ManufacturerId = storeExpenseReport.ProduserId,
        //            ReportDate = storeExpenseReport.ReportDate,
        //            Expense = storeExpenseReport.Expense
        //        });
        //    }

        //    gsmFactoryData.SaveChanges();
        //}

        //private void ParseExcelDataAndExportItInSqlServer(IEnumerable<DirectoryInfo> matchedDirectories)
        //{
        //    var salesReportFactory = new SalesReportGeneratorFromExcel(gsmFactoryData.Stores);
        //    var excelSaleReportReader = new ExcelSaleReportReader(ConnectionStrings.Default.ExcelConnectionString);

        //    foreach (var dir in matchedDirectories)
        //    {
        //        foreach (var excelFile in dir.GetFiles(Constants.ExcelFileExtensionPattern))
        //        {
        //            var excelData = excelSaleReportReader.CreateSaleReport(excelFile.FullName, dir.Name);
        //            var salesReport = salesReportFactory.CreateSalesReport(excelData, dir.Name);
        //            gsmFactoryData.SalesReports.Add(salesReport);
        //        }
        //    }

        //    this.gsmFactoryData.SaveChanges();
        //}
    }
}