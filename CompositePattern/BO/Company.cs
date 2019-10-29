using CompositePattern.BO;
using CompositePattern.BO.Interface;
using CompositePattern.DA;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Company : AbstractBusinessEntity
    {
        public Company(string number, string title):base(number, title)
        {
            Type = (int)Common.Helper.BusinessEntityType.Company;
        }

        public override void Validate(IValidationVisitor visitor, BusinessEntityData data)
        {
            visitor.VisitCompany(data);
        }
    }
}
