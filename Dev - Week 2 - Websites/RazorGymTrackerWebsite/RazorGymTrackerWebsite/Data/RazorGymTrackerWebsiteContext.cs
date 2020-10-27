using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GymTrackerWebsite.Models;

namespace RazorGymTrackerWebsite.Data
{
    public class RazorGymTrackerWebsiteContext : DbContext
    {
        public RazorGymTrackerWebsiteContext (DbContextOptions<RazorGymTrackerWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<GymTrackerWebsite.Models.User> User { get; set; }

        public DbSet<GymTrackerWebsite.Models.Session> Session { get; set; }
    }
}
