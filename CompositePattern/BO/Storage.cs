using CompositePattern.BO;
using CompositePattern.BO.Interface;
using CompositePattern.Common;
using CompositePattern.DA;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Storage : AbstractBusinessEntity
    {
        public Storage(string number, string title):base(number, title)
        {
            Type = (int)Common.Helper.BusinessEntityType.Storage;
        }

        public override void Validate(IValidationVisitor visitor, BusinessEntityData data)
        {
            visitor.VisitStorage(data);
        }
    }
}
