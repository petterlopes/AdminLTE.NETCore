using System;

namespace AdminLTE.NETCore.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class TreeViewSettingsAttribute : Attribute
    {
        public readonly string[] TreeViewSettings;

        //https://msdn.microsoft.com/en-us/library/w5zay9db.aspx
        public TreeViewSettingsAttribute(params string[] treeviewsettings)
        {
            this.TreeViewSettings = treeviewsettings;
        }
    }
}