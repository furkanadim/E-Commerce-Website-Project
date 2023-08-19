using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.DAL.Entities
{
    public class Slide
    {
        public int ID { get; set; }

        [Column(TypeName = "Varchar(50)"), StringLength(50), Display(Name = "Slogan")]
        public string Slogan { get; set; }

        [Column(TypeName = "Varchar(50)"), StringLength(50), Display(Name = "Slayt Başlığı"), Required(ErrorMessage ="Slayt başlığı boş bırakılamaz.")]
        public string Title { get; set; }

        [Column(TypeName = "Varchar(250)"), StringLength(250), Display(Name = "Slayt Açıklaması"), Required(ErrorMessage = "Slayt açıklaması boş bırakılamaz.")]
        public string Description { get; set; }

        [Column(TypeName = "Varchar(150)"), StringLength(150), Display(Name = "Resim Dosyası")]
        public string Picture { get; set; }

        [Column(TypeName = "decimal(18,2)"), Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        [Column(TypeName = "Varchar(150)"), StringLength(150), Display(Name = "Link Adresi")]
        public string Link { get; set; }

        [Display(Name ="Görüntüleme Sırası")]
        public int DisplayIndex { get; set; }
        
    }
}
