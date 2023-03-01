using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozmikOda.Concrete
{
    public class Hakkinda
    {
        [Key]public int HakkindaID { get; set; }
        [StringLength(1000)]public string HakkindaDetay1 { get; set; }
        [StringLength(1000)] public string HakkindaDetay2 { get; set; }
        [StringLength(100)] public string HakkindaResim1 { get; set; }
        [StringLength(100)] public string HakkindaResim2 { get; set; }
    }
}
