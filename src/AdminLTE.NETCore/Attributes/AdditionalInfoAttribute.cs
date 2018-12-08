using System;

namespace AdminLTE.NETCore.Attributes
{
    public class AdditionalInfoAttribute : Attribute
    {
        public readonly string AdditionalInfo;

        public AdditionalInfoAttribute(string additionalInfo)  // will be using to specify page page script for partial view rendering
        {
            this.AdditionalInfo = additionalInfo;
        }
    }
}