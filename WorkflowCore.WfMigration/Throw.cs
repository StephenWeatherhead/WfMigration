using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowCore.WfMigration
{
    public class Throw : StepBody
    {
        public Exception Exception { get; set; }
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            throw Exception;
        }
    }
}
