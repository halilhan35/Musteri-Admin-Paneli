using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesii.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string KullaniciAdi { get; set; }

        public string sifre { get; set; }
    }
}