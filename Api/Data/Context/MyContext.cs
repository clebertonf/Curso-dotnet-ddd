using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
    }
}
