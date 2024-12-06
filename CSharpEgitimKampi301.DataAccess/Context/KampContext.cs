using CSharpEgitimKampi301.EntityLayer_.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccess.Context
{
    //context klasörü: veri tabanı bağlantı adreslerinin tutulduğu ve veri tabanına yansayacak tabloları tuttuğumuz bir sınıf görevi görecektir. 
    public class KampContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        //bir sınıfın içinde yansıyacak olan tüm tabloları KampContext sınıfının içine yazılması gerekiyor. 
        //Caregory ifadesi c# tablosunda kullanacağımız sınıfın ismi.
        //categories ise sql e yansıyacak tablo ismi. bunun sebebi sınıf ve tablo karıştırılmasın diyedir. yalın hali class, çoğul hali tablodur.

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; } //admin daha az erişilebilir yani internal olduğundan public yapmalıyız. 



    }
}
