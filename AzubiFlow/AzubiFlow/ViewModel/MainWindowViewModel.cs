using AzubiFlow.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzubiFlow.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ObservableCollection<TaskDefinition> Tasks { get; set; }
        public ObservableCollection<ProjectDefinition> Projects { get; set; }
        public MainWindowViewModel()
        {

        }

        #region Properties

        public string Title
        {
            get { return "AzubiFlow"; }
        }

        private TaskDefinition selectedTasks;
        public TaskDefinition SelectedTasks        
        {
            get { return selectedTasks; }
            set { selectedTasks = value;
                OnPropertyChanged();
            }
        }

        private ProjectDefinition selectedproject;
        public ProjectDefinition Selectedproject
        {
            get { return selectedproject; }
            set { selectedproject = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
