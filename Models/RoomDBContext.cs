using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class RoomDBContext:DbContext
    {
        public RoomDBContext(DbContextOptions<RoomDBContext> options):base(options)
        {

        }

        public DbSet<RCandidate> RCandidate { get; set; }
    }
}
