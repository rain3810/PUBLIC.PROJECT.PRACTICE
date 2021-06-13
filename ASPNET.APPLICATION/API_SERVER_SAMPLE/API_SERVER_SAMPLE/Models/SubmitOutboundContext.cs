using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SERVER_SAMPLE.Models
{
    public class SubmitOutboundContext : DbContext
    {
        public SubmitOutboundContext(DbContextOptions<SubmitOutboundContext> options) : base(options)
        { }

        public DbSet<SubmitOutbound> TodoItems { get; set; }
    }
}
