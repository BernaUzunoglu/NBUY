using KuzeyCodeFirst.Models.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KuzeyCodeFirst.Models
{
    [Table("Urunler")]
    public class Urun : BaseEntity,IKey<int>
    {
        public Urun()
        {

        }
        [Key]
        public int Id { get; set; }

        [Required,StringLength(50)]
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public int KategorId { get; set; }//nullable olursa kategorisiz ürün eklenebilir.
        [Range(0,1000)]
        public int StokMiktari { get; set; }
        
        public bool DevamEtmiyor { get; set; }


        [ForeignKey(nameof(KategorId))]
        public Kategori Kategori { get; set; }
        public ICollection<SiparisDetay> SiparisDetaylari { get; set; } = new HashSet<SiparisDetay>();//Navigation property
    }
}
