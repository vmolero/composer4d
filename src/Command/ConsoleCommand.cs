using System;

namespace Command
{
  public class ConsoleCommand : Runnable
  {   
    private const int MIN_ARGS = 2;
    public string run(string[] arguments) {
      Runnable command;
      string output = "";
      if (arguments.Length < MIN_ARGS) {
        return this.getHelp();
      }
      try {
        command = this.getActualCommand(arguments);
        output = command.run(arguments);
      } catch (ArgumentException wrongArgument) {
        return wrongArgument.Message + "\n" + this.getHelp();
      }
      return output;
    }
  
    private string getHelp()
    {
      return "Usage: composer4d <command> [options]";
    }

    public Runnable getActualCommand(string[] arguments)
    {
      Runnable command;
      switch (arguments[1].ToLower())
      {
          case "update":
              command = new UpdateCommand();
              break;
          default:
              throw new ArgumentException("Wrong parameters.");
      }
      return command;
    }
  }
}