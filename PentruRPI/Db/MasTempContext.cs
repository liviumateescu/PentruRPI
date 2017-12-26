using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PentruRPI.Db
{
    public class MasTempContext : DbContext
    {
        public DbSet<MasuratoriTemperatura> MasuratoriSenzor01 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql(@"Server=localhost;database=PentruRPI;uid=root;pwd=123456;");
    }
}
