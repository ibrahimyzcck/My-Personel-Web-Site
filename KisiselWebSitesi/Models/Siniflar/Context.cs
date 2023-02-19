using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KisiselWebSitesi.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; } //admins tablosunda admin.cs deki kul ad şifre vs ulaşıp işlem yapabilmek için
        public DbSet<AnaSayfa> Anasayfas { get; set; }
        public DbSet<Ikonlar> Ikonlars { get; set; }
    }
}