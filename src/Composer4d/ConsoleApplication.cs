using System;
using Command;

namespace Composer4d
{
    class ConsoleApplication
    {
        protected Composer4d composer4d;

        protected 
        static void Main(string[] args)
        {
            string currentFolder = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(currentFolder);
            string[] arguments = System.Environment.GetCommandLineArgs();
            // 1st check for <current_project>.dproj
            //  use --dproj to force
            // extract dependencies
            
            CommandBase command = new CommandBase();
            
            Console.WriteLine(command.run(arguments));
        }
    }
}
