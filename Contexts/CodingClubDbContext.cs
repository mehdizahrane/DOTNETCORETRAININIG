using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CoreTraining.Models;
namespace CoreTraining.Contexts{
    public class CodingClubDbContext : DbContext
    {
        public CodingClubDbContext(DbContextOptions<CodingClubDbContext> options) :base(options) { }
        public DbSet<Article> Articles { get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}