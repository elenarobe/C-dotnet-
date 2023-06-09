﻿using ElenaWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace ElenaWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
