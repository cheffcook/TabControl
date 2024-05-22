using System.Collections.ObjectModel;

namespace Templates.TabControl.ViewModel
{
    public class TabControlViewModel
    {
        private readonly ObservableCollection<ProcessVariablesGroup> _processVariablesGroups;
        public ObservableCollection<ProcessVariablesGroup> ProcessVariablesGroups => _processVariablesGroups;

        public TabControlViewModel()
        {
            _processVariablesGroups = new ObservableCollection<ProcessVariablesGroup>
            {
                new ProcessVariablesGroup { Name = "P1A", IsActive = true, ProcessVariables = new ObservableCollection<string>() { "P1A1", "P1A2", "P1A3" } },
                new ProcessVariablesGroup { Name = "P1P", IsActive = false, ProcessVariables = new ObservableCollection<string>() { "P1P1", "P1P2", "P1P3" } },
                new ProcessVariablesGroup { Name = "P2A", IsActive = true, ProcessVariables = new ObservableCollection<string>() { "P2A1", "P2A2", "P2A3" } },
                new ProcessVariablesGroup { Name = "P2P", IsActive = false, ProcessVariables = new ObservableCollection<string>() { "P2P1", "P2P2", "P2P3" } },
                new ProcessVariablesGroup { Name = "P3A", IsActive = true, ProcessVariables = new ObservableCollection<string>() { "P3A1", "P3A2", "P3A3" } },
                new ProcessVariablesGroup { Name = "P3P", IsActive = false, ProcessVariables = new ObservableCollection<string>() { "P3P1", "P3P2", "P3P3" } }
            };
        }
    }
}
