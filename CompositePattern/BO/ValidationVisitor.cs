using CompositePattern.BO.Interface;
using CompositePattern.Common;
using CompositePattern.DA;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.BO
{
    public class ValidationVisitor : IValidationVisitor
    {
        public void VisitCorporation(BusinessEntityData data)
        {
            if (data.Type == (int)Helper.BusinessEntityType.Corporation)
                return;

            if (data.Type == (int)Helper.BusinessEntityType.Company)
                return;
                
            throw new BusinessEntityValidationException("You can add only Companies to Corporation");

        }
        public void VisitCompany(BusinessEntityData data)
        {
            if (data.Type == (int)Helper.BusinessEntityType.Facility)
                return;

            throw new BusinessEntityValidationException("You can add only Facility to Companies");
        }

        public void VisitFacility(BusinessEntityData data)
        {
            if (data.Type == (int)Helper.BusinessEntityType.Storage)
                return;

            throw new BusinessEntityValidationException("You can add only Storage to Facility");
        }

        public void VisitStorage(BusinessEntityData data)
        {
            throw new BusinessEntityValidationException("You can't add any business entity to Storage");
        }
    }
}
