using System;
using Command;

namespace Composer4d
{
  class ConsoleApp
  {
    protected Composer4d composer4d;
    
    protected static void Main(string[] args)
    {
      string currentFolder = System.IO.Directory.GetCurrentDirectory();
      CommandParser inputParser = new CommandParser(Composer4d.VERSION);

      // Console.WriteLine(currentFolder);
            
      // System.Environment.GetCommandLineArgs();
      // 1st check for <current_project>.dproj
      //  use --dproj to force
      // extract dependencies
      
      Runnable command = BaseCommand.create(inputParser, args);
      Console.WriteLine(command.run(args));
    }
  }
}
