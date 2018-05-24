using System;

namespace Composer4d
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = System.Environment.GetCommandLineArgs();
            // 1st check for <current_project>.dproj
            //  use --dproj to force
            // extract dependencies
            
            foreach (string argument in arguments) {
                Console.WriteLine(argument);
            } 
            Console.WriteLine("Hello World!");
        }
    }
}
