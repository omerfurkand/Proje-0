using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozmikOda.Concrete
{
    public class Icerik
    {
        [Key]
        public int IcerikID { get; set; }
        [StringLength(1000)]
        public string IcerikDegeri { get; set; }
        public DateTime BaslikTarihi { get; set; }

        public int? BaslikID { get; set; }
        public virtual Baslik Basliklar { get; set; }

        public int YazarID { get; set; }
        public virtual Yazar Yazar { get; set; }
    }
}
