using CompositePattern.BO.Interface;
using CompositePattern.DA;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CompositePattern.BO
{
    public abstract class AbstractBusinessEntity : IBusinessEntity
    {

        public string Title { get; set; }
        public string Number { get; set; }

        public int Type { get; set; }

        public AbstractBusinessEntity(string number, string title)
        {
            Title = title;
            Number = number;
        }

        public void AddBusinessEntity(IBusinessEntity entity)
        {
            var currentElement = Context.BusinessEntityList.FirstOrDefault(x => x.Number == this.Number);

            var visitor = new ValidationVisitor();
            var data = new BusinessEntityData()
            {
                ID = Guid.NewGuid(),
                Title = entity.Title,
                Number = entity.Number,
                Type = entity.Type,
                ParentID = currentElement == null ? Guid.Empty : currentElement.ID
            };

            Validate(visitor, data);
            Context.BusinessEntityList.Add(data);
        }

        public List<BusinessEntityData> GetChildren(string number = null)
        {
            if (number == null)
                number = this.Number;

            List<BusinessEntityData> list = new List<BusinessEntityData>();
            var currentElement = Context.BusinessEntityList.FirstOrDefault(x => x.Number == number);

            if (currentElement == null)
                return new List<BusinessEntityData>();

            var children = Context.BusinessEntityList.Where(x => x.ParentID == currentElement.ID);

            foreach(var item in children)
            {
                list.Add(item);
                list.AddRange(GetChildren(item.Number));
            }

            return list;
        }

        public void Remove(IBusinessEntity entity)
        {
            var result = Context.BusinessEntityList.FirstOrDefault(x => x.Number == entity.Number);

            if (result == null)
                return;

            Context.BusinessEntityList.Remove(result);
        }

        public abstract void Validate(IValidationVisitor visitor, BusinessEntityData data);
    }
}
