using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowCore.WfMigration
{
    public class WriteLine : StepBody
    {
        public string Text { get; set; }
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine(Text);
            return ExecutionResult.Next();
        }
    }
}
