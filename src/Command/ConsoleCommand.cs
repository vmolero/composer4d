using System;
using System.Collections.Generic;
using DocoptNet;

namespace Command
{
  public class ConsoleCommand : Runnable
  {   
    private const int MIN_ARGS = 2;
    public string run(IList<string> arguments) {
      Runnable command;
      var argument = new Docopt().Apply(
        this.getHelp(), 
        arguments, 
        version: "Composer4D 1.0", 
        exit: true
      );
      foreach (var argumen in argument)
      {
          Console.WriteLine("{0} = {1}", argumen.Key, argumen.Value);
      }
      string output = "";
      return output;
      if (arguments.Count < MIN_ARGS) {
        return this.getHelp();
      }
      try {
        // command = this.getActualCommand(arguments);
        output = command.run(arguments);
      } catch (ArgumentException wrongArgument) {
        return wrongArgument.Message + "\n" + this.getHelp();
      }
      return output;
    }

    private string getHelp() => @"Composer for Delphi.
Usage:
  composer4d <command> [Options]
  composer4d (-h | --help)
  composer4d --version

Options:
  command       (update|install|init)
  -h --help     Show this screen.
  --version     Show version.

";
/*

:
  init          Create file composer4d.json
  update        Update dependencies
  install       Install fixed version dependencies
 */
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
