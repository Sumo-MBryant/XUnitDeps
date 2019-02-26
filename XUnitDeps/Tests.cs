using System.Linq;
using Xunit.Runners;

namespace XUnitDeps
{
    public class Tests
    {
        public static void Test()
        {
            using (var assemblyRunner = AssemblyRunner.WithoutAppDomain(typeof(Tests).Assembly.Modules.First().FullyQualifiedName))
            {
            }
        }
    }
}
