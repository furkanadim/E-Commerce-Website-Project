using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.DAL.Entities
{
    public class Admin
    {
        public int ID { get; set; }

        [Column(TypeName = "Varchar(20)"), StringLength(20), Display(Name = "Kullanıcı Adı"), Required(ErrorMessage ="Kullanıcı adı boş bırakılamaz.")]
        public string UserName { get; set; }

        [Column(TypeName = "Varchar(32)"), StringLength(32), Display(Name = "Parola"), Required(ErrorMessage ="Parola kısmı boş bırakılamaz")]
        public string Password { get; set; }

        [Column(TypeName = "Varchar(50)"), StringLength(50), Display(Name = "Admin Adı"), Required(ErrorMessage ="Ad Soyad kısmı boş bırakılamaz.")]
        public string NameSurname { get; set; }

        [Display(Name ="Son Giriş Tarihi")]
        public DateTime LastLongDate { get; set; }

        [Column(TypeName = "Varchar(20)"), StringLength(20), Display(Name = "Son Admin Giriş IP Adresi"), Required(ErrorMessage = "Son Giriş No")]
        public string LastLoginIP { get; set; }
    }
}
