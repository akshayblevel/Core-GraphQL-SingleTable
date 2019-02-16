using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLGraphTypeFirstSingleTable
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly GraphQLDemoContext _context;
        public EmployeeRepository(GraphQLDemoContext context)
        {
            _context = context;
        }

        public Task<List<Employee>> GetEmployees()
        {
            return _context.Employee.ToListAsync();
        }
    }

}
