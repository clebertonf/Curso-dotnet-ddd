using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
   public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)  { }
        public DbSet<UserEntity> Users { get; set; }

    }
}
