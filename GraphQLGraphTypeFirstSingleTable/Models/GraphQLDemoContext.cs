using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLGraphTypeFirstSingleTable
{
    public partial class GraphQLDemoContext : DbContext
    {
        public GraphQLDemoContext()
        {
        }

        public GraphQLDemoContext(DbContextOptions<GraphQLDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
    }

}
