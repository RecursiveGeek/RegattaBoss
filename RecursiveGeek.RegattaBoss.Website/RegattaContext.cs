using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecursiveGeek.RegattaBoss.Models;

namespace RecursiveGeek.RegattaBoss.Website
{
    public class RegattaContext : DbContext
    {
        public DbSet<Cart> Carts { get; set; }
    }
}
