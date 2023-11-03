using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Learn90.SupportForCodeGenerators
{
    public class ModuleInitializers
    { 
        static string _name="Temp";
        public static void Test()
        {
            Console.WriteLine(_name);
        }
        [ModuleInitializer]
        internal static async  void M1() //The method must be static, parameterless, return void,not be generic/be internal or public
        {    
            _name = await GetName();
           // var binPath = ThisAssembly.Project.MSBuildBinPath;
           // Microsoft.Build.Locator.MSBuildLocator.RegisterMSBuildPath(binPath);
            // Set environment variables so SDKs can be resolved. 
           // Environment.SetEnvironmentVariable("MSBUILD_EXE_PATH", Path.Combine(binPath, "MSBuild.exe"), EnvironmentVariableTarget.Process);
        } 
        static Task<string> GetName() => Task.FromResult("Module initialized");
    }
}