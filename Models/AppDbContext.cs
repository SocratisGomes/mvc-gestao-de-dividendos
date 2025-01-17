﻿using Microsoft.EntityFrameworkCore;

namespace mvc_gestao_de_dividendos.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ativo> Ativos { get; set; }
    }
}
