namespace GsmFactory.Data.ReportProcessors
{
    using System;
    using System.Linq;
    using GsmFactory.Data.Contracts;
    using GsmFactory.Models;
    using GsmFactory.ReportCreators;

    public class ExpensesReportFactoryFromXmlData
    {
        private readonly IGenericRepository<Producer> produserRepository;

        public ExpensesReportFactoryFromXmlData(IGenericRepository<Producer> produserRepository)
        {
            this.produserRepository = produserRepository;
        }

        public ProduserExpense CreateStoreExpensesReport(XmlReportCreator xmlVendorExpenseEntry)
        {

            throw new NotImplementedException();


            //var produserer = this.produserRepository
            //                       .All()
            //                       .FirstOrDefault(s => s.Name == xmlVendorExpenseEntry); // .ProduserName);

            //var expenseReport = new ProduserExpense()
            //{
            //    ReportDate = xmlVendorExpenseEntry.SaleDate,
            //    Expense = xmlVendorExpenseEntry, //.Expense,
            //    ProducerId = produserer.Id  
            //    };

            //return expenseReport;
        }
    }
}