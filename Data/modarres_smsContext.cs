using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modarres_sms.Models;

namespace modarres_sms.Data
{
    public class modarres_smsContext : DbContext
    {
        public modarres_smsContext(DbContextOptions<modarres_smsContext> options)
            : base(options)
        {
        }

        public DbSet<modarres_sms.Models.user>? user { get; set; } = default!;
        public DbSet<modarres_sms.Models.never>? never { get; set; }
        public DbSet<modarres_sms.Models.v_nbt_sms2>? v_nbt_sms2 { get; set; }
        public DbSet<modarres_sms.Models.v_nbt_sms1>? v_nbt_sms1 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<v_nbt_sms3>()
            //.ToView(nameof(v_nbt_sms2))
            //.HasNoKey();

           // modelBuilder.Entity<v_nbt_sms2>()
           //.ToView(nameof(v_nbt_sms2))
           //.HasNoKey();

        }

    }
}
