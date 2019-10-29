using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Common
{
    public class BusinessEntityValidationException:Exception
    {
        public BusinessEntityValidationException(string exception):base(exception)
        {

        }
    }
}
