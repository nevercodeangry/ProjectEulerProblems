using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eulerprojects.Core;
using eulerprojects.Projects;

namespace eulerprojects
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<OutputToConsole>().As<IOutput>();
            builder.RegisterType<EulerProject4>().As<IProject>()
                .UsingConstructor(typeof(IOutput));
            
            Container = builder.Build();
            Execute();
            Console.Read();
        }
        public static void Execute()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var output = scope.Resolve<IOutput>();
                var project = scope.Resolve<IProject>();
                project.Run();
            }
        }
    }
}
