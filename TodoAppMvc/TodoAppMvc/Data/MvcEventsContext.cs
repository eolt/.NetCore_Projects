using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoAppMvc.Models;

    public class MvcEventsContext : DbContext
    {
        public MvcEventsContext (DbContextOptions<MvcEventsContext> options)
            : base(options)
        {
        }

        public DbSet<TodoAppMvc.Models.Event> Event { get; set; }
    }
