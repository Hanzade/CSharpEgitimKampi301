using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer_.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; } 
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; } 
        public bool CustomerStatus { get; set; }


        //solid prensipleri -- 3. case makale yazmak 
        //single responsibilty - tek sorumluluk ilkesi - bir sınıf / bir metot / interface bağlı bulunduğu alanda sadece tek bir işlem yapmalı


    }
}
