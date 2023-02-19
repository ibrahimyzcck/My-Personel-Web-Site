using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebSitesi.Models.Siniflar
{
    public class Ikonlar
    {
        [Key]
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Link { get; set; }
    }
}