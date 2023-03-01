using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IcIsleri.Concrete.Havuzlar;
using KozmikOda.Concrete;

namespace SinirKapisi.Concrete
{
    public class KategoriYonetimi
    {
        EsnekHavuz<Kategori> hvz = new EsnekHavuz<Kategori> ();
        public List<Kategori> HepsiniGetir()
        {
            return hvz.Liste();
        }
        public void KategoriEkle(Kategori k)
        {
            //Bu doğrulamayı şimdilik yapıyoruz. İleride zaten doğrulamanın yapılabileceği farklı bir kullanım alanımız olacak.
            if (k.KategoriAd ==  ""||k.KategoriAd.Length<=3||k.KategoriAciklama==""||k.KategoriAciklama.Length>=51)
            {
                //Hata mesajı.
            }
            else
            {
                hvz.Ekle(k);
            }
        }
    }
}
