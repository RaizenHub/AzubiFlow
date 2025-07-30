using AzubiFlow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzubiFlow.ViewModel
{
    public class ProjectDefinitionViewModel
    {
        private readonly ProjectDefinition _project;
        public ProjectDefinitionViewModel(ProjectDefinition project) 
        {
            _project = project;
            Tasks = new List<TaskDefinitionViewModel>();
        }
        public List<TaskDefinitionViewModel> Tasks { get; }

        public string ProjectName 
        { 
            get { return _project.ProjectName; }            
        }
    }
}
