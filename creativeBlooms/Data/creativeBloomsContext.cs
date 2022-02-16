using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using creativeBlooms.Models;

    public class creativeBloomsContext : DbContext
    {
        public creativeBloomsContext (DbContextOptions<creativeBloomsContext> options)
            : base(options)
        {
        }

        public DbSet<creativeBlooms.Models.Flower> Flower { get; set; }
    }
