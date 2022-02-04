using System;
using System.ComponentModel.DataAnnotations;
using WebCrud.Models.Enums;

namespace WebCrud.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2")]
        public double Amount { get; set; }
        public SalesRecord Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SalesRecord status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

        public SalesRecord(int v1, DateTime dateTime, double v2, SalesStatus billed, Seller s1)
        {
        }
    }
}
