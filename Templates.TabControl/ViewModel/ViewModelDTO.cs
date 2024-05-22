using System.Collections.ObjectModel;

namespace Templates.TabControl.ViewModel
{
    public class ProcessVariablesGroup
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        public ObservableCollection<string> ProcessVariables { get; set; } = new ObservableCollection<string>();
    }
}
