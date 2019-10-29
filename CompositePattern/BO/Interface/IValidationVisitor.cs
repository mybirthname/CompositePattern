using CompositePattern.DA;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.BO.Interface
{
    public interface IValidationVisitor
    {
        void VisitCompany(BusinessEntityData data);
        void VisitFacility(BusinessEntityData data);
        void VisitCorporation(BusinessEntityData data);
        void VisitStorage(BusinessEntityData data);

    }
}
