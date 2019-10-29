using CompositePattern.DA;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.BO.Interface
{
    public interface IBusinessEntity
    {
        string Title { get; set; }
        string Number { get; set; }

        int Type { get; set; }

        List<BusinessEntityData> GetChildren(string number);
        void AddBusinessEntity(IBusinessEntity entity);
        void Remove(IBusinessEntity entity);

        void Validate(IValidationVisitor visitor, BusinessEntityData data);
    }
}
