using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLGraphTypeFirstSingleTable
{
    public class EmployeeQuery : ObjectGraphType
    {
        public EmployeeQuery(IEmployeeRepository employeeRepository)
        {
            Field<ListGraphType<EmployeeType>>(
                "employees",
                resolve: context => employeeRepository.GetEmployees()
                );
        }
    }

}
