﻿using E_Commerce.Comment.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Comment.Context
{
    public class CommentContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1442;initial Catalog=E_CommerceCommentDb;User=sa;Password=123456789aA*");
        }
        public DbSet<UserComment> UserComments { get; set; }
    }
}
