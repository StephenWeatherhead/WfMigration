using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.WfMigration;
using WorkflowCore.Models;

namespace CoreWorkflows
{
    public class TryCatchFlow : IWorkflow
    {
        public string Id => nameof(TryCatchFlow);

        public int Version => 1;

        public void Build(IWorkflowBuilder<object> builder)
        {
            builder
                .StartWith<Throw>()
                .Input(step => step.Exception, data => new Exception("This is my error"))
                .CompensateWith<WriteLine>(stepBuilder => stepBuilder.Input(step => step.Text, data => "An exception was thrown: "));
        }
    }
}
