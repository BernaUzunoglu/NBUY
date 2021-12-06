using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KuzeyCodeFirst.Models
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public int KategorId { get; set; }//nullable olursa kategorisiz ürün eklenebilir.
        [Range(0,1000)]
        public int StokMiktari { get; set; }


        [ForeignKey(nameof(KategorId))]
        public Kategori Kategori { get; set; }
    }
}
