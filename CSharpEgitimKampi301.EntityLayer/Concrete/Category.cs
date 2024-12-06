using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        //access modifiers -- erişim belirleyicileri
        //public -- solutionun altındaki her yer den erişilebilir
        //private -- sadece bulunduğu alandan erişim sağlanır
        //internal -- sadece bulunduğu katmandan erişim sağlanır
        //protected -- sadece bir sınıf ve o sınıfı miras alan yerlerde kullanılabilir

        public string CategoryId { get; set; } //prop + tab  //burada gönderilmiş olan değerin istenen formatta kullanılması //kod first yaklaşımına göre: category ıdnın birincil anahtar olduğunu ve otomatik artan olduğunu bildirmek adına sınıfın ismi birebir aynı yazılmalı ve sonuna id getirilmelidir. 
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }



    }




    /*
      field - variable - property tanımlarının arasında fark vardır.

    int x - direkt sınıfın içinde tanımlanırsa : field

    eğer o değişken yapısı {get;set;} yapısı alırsa: property

    eğer bir metod içinde tanımlanırsa : değişken oluyor 

     */
}
