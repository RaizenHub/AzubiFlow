using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzubiFlow.Model;

namespace AzubiFlow.ViewModel
{
    public class TaskDefinitionViewModel : BaseViewModel
    {
        private readonly TaskDefinition _task;
        public TaskDefinitionViewModel(TaskDefinition task)
        {
            _task = task;
        }
        public string TaskName 
        { 
            get { return _task.TaskName; }
        }

        public double TaskTime 
        { 
            get { return _task.TaskTime; }
        }
        public DateOnly TaskDate 
        {
            get { return _task.TaskDate; }
        }
    }
}
