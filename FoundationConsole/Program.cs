using FoundationWorkflows;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TryCatchFlow l_Flow = new TryCatchFlow();
            WorkflowInvoker.Invoke(l_Flow);
            Console.ReadKey();
        }
    }
}
