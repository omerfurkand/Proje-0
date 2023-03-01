using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozmikOda.Concrete
{
    public class Yazar
    {
        [Key]public int YazarID { get; set; }
        [StringLength(50)]public string YazarAd { get; set; }
        [StringLength(50)]public string YazarSoyad { get; set; }
        [StringLength(100)]public string YazarResim { get; set; }
        [StringLength(50)]public string YazarMail { get; set; }
        [StringLength(20)]public string YazarSifre { get; set; }

        public ICollection<Baslik> Basliklar { get; set; }
        public ICollection<Icerik> Icerikler { get; set; }
    }
}
