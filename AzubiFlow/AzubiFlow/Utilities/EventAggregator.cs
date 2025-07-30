using AzubiFlow.Model;
using AzubiFlow.ViewModel;


namespace AzubiFlow.Utilities
{
    public class EventAggregator
    {
        public EventAggregator()
        {

        }
        public event EventHandler<ProjectDefinitionViewModel> SelectedProjectEvent;
        public void OnSelectedProjectEvent(ProjectDefinitionViewModel projectDefinitionViewModel)
        {
            SelectedProjectEvent?.Invoke(null, projectDefinitionViewModel);
        }
    }
}
