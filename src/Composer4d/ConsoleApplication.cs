using System;
using Command;

namespace Composer4d
{
    class ConsoleApplication
    {
        static void Main(string[] args)
        {
            string[] arguments = System.Environment.GetCommandLineArgs();
            // 1st check for <current_project>.dproj
            //  use --dproj to force
            // extract dependencies
            CommandBase command = new CommandBase();
            command.run(arguments);
        }
    }
}
