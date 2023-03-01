using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IcIsleri.Concrete.Havuzlar
{
    public class EsnekHavuz<T>:IHavuz<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _obje;
        public EsnekHavuz(){_obje = c.Set<T>(); }
        public void Ekle(T p)
        {
            _obje.Add(p);
            c.SaveChanges();
        }

        public void Guncelle(T p)
        {
            c.SaveChanges();
        }

        public List<T> Liste()
        {
            return _obje.ToList();
        }

        public List<T> Liste(Expression<Func<T, bool>> filter)
        {
            return _obje.Where(filter).ToList();
        }

        public void Sil(T p)
        {
            _obje.Remove(p);
            c.SaveChanges();
        }
    }
}
