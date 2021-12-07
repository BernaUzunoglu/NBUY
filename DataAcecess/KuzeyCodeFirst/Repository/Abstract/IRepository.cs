using KuzeyCodeFirst.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyCodeFirst.Repository
{
    // bir ifadenin başına in keywordu eklenirse kullanılabilir değiştirilemez anlamına gelmektedir.
    public interface IRepository<T,in TId> where T : BaseEntity// where ile basentity tipinde şartı ekliyor. T kısıt
    {
        T GetById(TId id);
        IQueryable<T> GetAll(Func<T,bool> predicate=null);// IQueryable ile verinin nasıl gelleceğini tutuyoruz.Yani bir türe bağlı kısıtlamıyoruz

        void Add(T entity,bool isSaveLater=false);// SaveLater true ise save changes calışması için bir kontrol 
        void Remove(T entity, bool isSaveLater = false);
        void Update(T entity, bool isSaveLater = false);

        //SaveLaterların hepsi true olunca save() metodu ile toplu kayıt
        int Save();

    }
}
