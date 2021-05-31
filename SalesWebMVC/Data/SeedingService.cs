using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
               return; //DB já foi populado.
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Suport");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Wendi", "Wendi@gmail.com", new DateTime(1999, 3, 18), 1000.0, d1);
            Seller s2 = new Seller(2, "Carlos", "Carlos@gmail.com", new DateTime(1998, 4, 19), 2000.0, d2);
            Seller s3 = new Seller(3, "Christopher", "Christopher@gmail.com", new DateTime(1997, 5, 20), 2000.0, d3);
            Seller s4 = new Seller(4, "Luiz", "Luiz@gmail.com", new DateTime(1996, 6, 21), 1000.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 9, 25), 1200.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 9, 28), 356.0, SaleStatus.Billed, s3);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 9, 10), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 9, 12), 2200.0, SaleStatus.Billed, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 8, 24), 1345.0, SaleStatus.Billed, s2);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 8, 25), 9876.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6);

            _context.SaveChanges();
        }
    }
}
