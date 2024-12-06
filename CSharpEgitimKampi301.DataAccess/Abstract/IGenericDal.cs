using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccess.Abstract
{
    public interface IGenericDal<T> where T: class //dışarıdan bir t değeri alınacak
    {
        //bütün entityler için metodlar tanımlandı
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);

    }
}
