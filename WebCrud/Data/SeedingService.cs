using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCrud.Data.Models;
using WebCrud.Models;
using WebCrud.Models.Enums;

namespace WebCrud.Data
{
    public class SeedingService
    {
        private WebCrudContext _context;

        public SeedingService(WebCrudContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB foi alimentado
            }

            Department d1 = new Department(1, "Computer");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "João", "joao@gmail.com", new DateTime(1997, 3, 20), 2000.0, d2);
            Seller s3 = new Seller(3, "Maria", "maria@gmail.com", new DateTime(1996, 2, 19), 3000.0, d3);
            Seller s4 = new Seller(4, "Carlos", "carlos@gmail.com", new DateTime(1995, 1, 18), 4000.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 26), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2017, 08, 25), 22000.0, SalesStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2016, 07, 24), 33000.0, SalesStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2015, 06, 23), 44000.0, SalesStatus.Billed, s2);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2014, 05, 22), 55000.0, SalesStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2013, 04, 21), 66000.0, SalesStatus.Billed, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2012, 02, 20), 77000.0, SalesStatus.Billed, s4);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2011, 02, 19), 88000.0, SalesStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8
            );

            _context.SaveChanges();
        }
    }
}
