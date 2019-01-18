using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VideoOnDemand.Data.Entities;

namespace VideoOnDemand.Data.Data
{
    public class VODContext:IdentityDbContext<User>
    {
        public VODContext(DbContextOptions<VODContext> options)
        :base(options)
        {           
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
