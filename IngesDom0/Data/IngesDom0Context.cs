using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IngesDom0.Models;

namespace IngesDom0.Data
{
    public class IngesDom0Context : DbContext
    {
        public IngesDom0Context (DbContextOptions<IngesDom0Context> options)
            : base(options)
        {
        }

        public DbSet<IngesDom0.Models.User> User { get; set; }
    }
}
