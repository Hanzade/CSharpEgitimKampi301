using CSharpEgitimKampi301.EntityLayer_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccess.Abstract
{
    public interface ICategoryDal:IGenericDal<Category> //Igenericdal dan category sınıfı için miras alacak
    {
    }
}
