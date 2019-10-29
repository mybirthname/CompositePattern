using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.DA
{
    public class BusinessEntityData
    {
        public Guid ID { get; set; }

        public Guid ParentID { get; set; }

        public string Title { get; set; }
        public string Number { get; set; }

        public int Type { get; set; }
    }

    public static class Context
    {
        public static List<BusinessEntityData> BusinessEntityList { get; set; } = new List<BusinessEntityData>();
    }
}
