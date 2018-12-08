using System;

namespace AdminLTE.NETCore.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class DisplayOrderAttribute : Attribute
    {
        public readonly int DisplayOrder;

        public DisplayOrderAttribute(int order)  // order is a positional parameter
        {
            this.DisplayOrder = order;
        }
    }
}