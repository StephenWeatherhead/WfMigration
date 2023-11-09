using CoreWorkflows;
using Microsoft.Extensions.DependencyInjection;
using WorkflowCore.Interface;

namespace CoreConsole;
class Program
{
    static void Main(string[] args)
    {
        var l_ServiceProvider = ConfigureServices();
        var l_Host = l_ServiceProvider.GetService<IWorkflowHost>();
        l_Host.RegisterWorkflow<TryCatchFlow>();
        l_Host.Start();
        l_Host.StartWorkflow("TryCatchFlow");
        Console.ReadKey();
        l_Host.Stop();
    }

    private static IServiceProvider ConfigureServices()
    {
        IServiceCollection l_Services = new ServiceCollection();
        l_Services.AddLogging();
        l_Services.AddWorkflow();
        var l_ServiceProvider = l_Services.BuildServiceProvider();
        return l_ServiceProvider;
    }
}