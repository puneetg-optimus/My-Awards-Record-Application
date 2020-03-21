using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyAwardsCollection.Models;

namespace MyAwardsCollection.Data
{
    public class AwardsContext : DbContext
    {
        public AwardsContext(DbContextOptions<AwardsContext> options): base(options)
        {

        }
        public DbSet<MyAwards> awards { get; set; }
    }
}
