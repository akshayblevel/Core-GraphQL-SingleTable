using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLGraphTypeFirstSingleTable
{
    public class EmployeeSchema : Schema
    {
        public EmployeeSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<EmployeeQuery>();
        }
    }

}
