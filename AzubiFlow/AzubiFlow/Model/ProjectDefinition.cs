using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzubiFlow.Model
{
    public class ProjectDefinition
    {
        public ProjectDefinition()
        {
            Tasks = new List<TaskDefinition>();
        }
        public string ProjectName { get; set; }
        public List<TaskDefinition> Tasks { get; set; }
    }
}
