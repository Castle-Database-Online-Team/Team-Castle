namespace GsmFactory.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProduserExpense
    {
        [Key]
        public int ExpenseId { get; set; }

        public DateTime ReportDate { get; set; }

        public decimal Expense { get; set; }

        [ForeignKey("Producer")]
        public int ProducerId { get; set; }

        public virtual Producer Manufacturer { get; set; }
    }
}