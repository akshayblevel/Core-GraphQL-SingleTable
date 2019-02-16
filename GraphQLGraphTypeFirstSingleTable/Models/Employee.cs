using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLGraphTypeFirstSingleTable
{
    public partial class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }

}
