using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskInfo.Models
{
    public class MaskContext : DbContext
    {
        public DbSet<MedicalMask> MedicalMasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=MedicalMask.db");
    }
}
