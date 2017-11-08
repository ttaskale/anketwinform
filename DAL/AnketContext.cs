using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class AnketContext:DbContext
    {   
        public virtual DbSet<Soru> Sorular { get; set; }
        public virtual DbSet<Cevap> Cevaplar { get; set; }
        public virtual DbSet<Kisi> Kisiler { get; set; }
    }
}
