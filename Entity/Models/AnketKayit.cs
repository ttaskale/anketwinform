using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("tblSorular")]
    public class Soru
    {   [Key]
        public int SoruID { get; set; }
        [Required]//Soru cümlesi zorunlu string struct olmadığından bos gelebilir
        public string SoruCumlesi { get; set; }

        
    }
    [Table("tblKisiler")]
    public class Kisi
    {
        [Key]
        public int KisiID { get; set; }
        [Required]
        public string AdSoyad { get; set; }
    }
    [Table("tblCevaplar")]
    public class Cevap
    {
        [Key]
        public int CevapID { get; set; }
        [ForeignKey("CevabiVerenKisi")]// bu FK'nin dolduracağı virtual Navigation Property CevabiVerenKisi'dir
        public int KisiID { get; set; }
        [ForeignKey("Sorusu")]
        public int SoruID { get; set; }
        public Yanit Yanit { get; set; }

        public virtual Kisi CevabiVerenKisi { get; set; }
        public virtual Soru Sorusu { get; set; }
    }
    public enum Yanit
    {
        Hayir,
        Evet
    }
}
