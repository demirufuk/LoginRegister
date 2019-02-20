using Microsoft.EntityFrameworkCore;
using SehirDefteri.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirDefteri.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions <DataContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
