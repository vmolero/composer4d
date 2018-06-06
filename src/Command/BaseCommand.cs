using System;
using System.Collections.Generic;
using DocoptNet;

namespace Command
{
  public abstract class BaseCommand : Configurable
  {
    private const string INIT = "init";
    private const string UPDATE = "update";
    public const string ACTION_ARG = "<action>";
    public const string FILE_ARG = "<file>";
    protected const string HELP = @"Composer for Delphi (Composer4D).
Usage:
  composer4d " + ACTION_ARG + @" [" + FILE_ARG + @"]
  composer4d (-h | --help)
  composer4d --version

Actions:
  init          Create a json file
  update        Update dependecies
  install       Install dependencies

Options:
  -h --help     Show this screen.
  --version     Show version.
";
    protected static IDictionary<string, ValueObject> arguments;
    public static Runnable create(CommandParser parser, string[] args)
    {
      Runnable command = new NoopCommand();
      arguments = parser.Apply(HELP, args);
      string action = arguments[ACTION_ARG].ToString().ToLower();
      switch (action) {
        case INIT:
          string file = arguments[FILE_ARG].ToString();
          //command = new InitCommand(file);
          break;
        case UPDATE:
          command = new UpdateCommand();
          break;
        default:
          // command = new HelpCommand();
          break;
      }

      return command;
    }
    protected string name;
    public string Name {
      set { name = value.ToLower(); }
      get { return name; }
    }
    protected string help;
    public string Help {
      set { help = value; }
      get { return HELP; }
    }
    protected string[] aliases;
    public string[] Aliases {
      set { aliases = value; }
      get { return aliases; }
    }
    protected string[] definition;
    public string[] Definition {
      set { definition = value; }
      get { return definition; }
    }
    protected string description;
    public string Description {
      set { description = value; }
      get { return description; }
    }
    public abstract void configure();
    public BaseCommand() => this.configure();
  }
}