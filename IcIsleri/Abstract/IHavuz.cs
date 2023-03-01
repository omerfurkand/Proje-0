using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IcIsleri.Concrete.Havuzlar
{
    public interface IHavuz<T>
    {
        List<T> Liste();
        void Ekle(T p);
        void Sil(T p);
        void Guncelle(T p);
        List<T> Liste(Expression<Func<T, bool>>filter);
    }
}
