using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer_.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; } 

        public virtual Category Category { get; set; } //category tablosu ile ilişkilendirildi //kategori tablosunun değerlerine ürün tablosundan erişebilmek için eklendi.
        public List<Order> Orders { get; set; }


        //referanslar nasıl çalışır?
        /*
          Uygulamamızda 4 tane katman var. bu katmanlar birbirini refere eder.

        ""Entity Layer""  --entity katmanı data accesse referans olarak verilecek.
                                    ""Data Access Layer""-- data katmanı buisness a referans olarak verilecek.
                                                            ""Business Layer"" -- buısness katmanı presentation referans olarak verilecek.
                                                                                     ""Presentation Layer"" --en üstte presentation katmanı yer alır. 

        böylece her katman birbiri ile haberleşir. her bir katman bir önceki katmanı kapsar. 
         */
    }
}
