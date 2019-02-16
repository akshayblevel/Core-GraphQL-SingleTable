using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLGraphTypeFirstSingleTable
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(a => a.Id);
            Field(a => a.Name);
            Field(a => a.Email);
            Field(a => a.Mobile);
            Field(a => a.Company);
            Field(a => a.Address);
            Field(a => a.ShortDescription);
            Field(a => a.LongDescription);
        }
    }

}
