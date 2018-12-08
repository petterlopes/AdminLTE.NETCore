using AdminLTE.NETCore.Attributes;

namespace AdminLTE.NETCore.Models
{
    public class ActionInfo
    {
        public string ActionName { get; set; }
        public string DisplayName { get; set; }
        public string DisplayImage { get; set; }
        public string ScriptAfterPartialView { get; set; }
        public TreeViewAttribute TreeViewSettings { get; set; }
        public TreeViewSettingsAttribute TreeViewSettings2 { get; set; }
    }
}