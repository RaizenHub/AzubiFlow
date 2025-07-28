using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzubiFlow.Model
{
    public class TaskDefinition
    {
        public string Task { get; set; }
        public double TaskTime { get; set; }
        public DateOnly Date { get; set; }
    }
}
