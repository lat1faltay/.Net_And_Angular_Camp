using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
                                         // generic constraint
                                         // class = referans tip demektir
                                         // T class yani verilen t parametreleri referans tip olabilir anlamında
                                         // fakat başka referans tipler verilirse t parametresine, kullandığımız ye yine de kabul eder
                                         // bunun için IEntity yazdık ki sadece IEntity'den implement olanlar ya da IEntity'yi kabul etsin
                                         // new() kuralı da new'lenemeyen sınıfları kabul etmemesi içindi yani artık kullandığımız yerde
                                         // T parametresine sadece IEntity'den implement edilen ve new'lenen classlar verilebilecek
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
