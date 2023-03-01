using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozmikOda.Concrete
{
    public class Baslik
    {
        [Key]
        public int BaslikID { get; set; }

        [StringLength(50)]
        public string BaslikAdi { get; set; }
        public DateTime BaslikTarihi { get; set; }

        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }

        public ICollection<Icerik> Icerikler { get; set;}

        public int YazarID { get; set; }
        public virtual Yazar Yazar { get; set; }

    }
}
