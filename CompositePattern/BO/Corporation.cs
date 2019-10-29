using CompositePattern.BO;
using CompositePattern.BO.Interface;
using CompositePattern.DA;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Corporation: AbstractBusinessEntity
    {
        public Corporation(string number, string title):base(number, title)
        {
            Type = (int)Common.Helper.BusinessEntityType.Corporation;
        }

        public override void Validate(IValidationVisitor visitor, BusinessEntityData data)
        {
            visitor.VisitCorporation(data);
        }
    }
}
