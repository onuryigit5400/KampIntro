using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }//UrunAdi
        public double UnitPrice { get; set; }//UrunFiyati
        public int UnitsInStock { get; set; }//StokAdedi

    }
}
