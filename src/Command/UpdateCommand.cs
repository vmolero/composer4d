using System;

namespace Command
{
  public class UpdateCommand : Runnable, Configurable
  {
    private string name;
    public string Name {
      set { name = value.ToLower(); }
    }
    private string help;
    public string Help {
      set { help = value; }
    }
    private string[] aliases;
    public string[] Aliases {
      set { aliases = value; }
    }
    private string[] definition;
    public string[] Definition {
      set { definition = value; }
    }
    private string description;
    public string Description {
      set { description = value; }
    }
    public void configure()
    {
      this.Name = "update";
      this.Aliases = new string[] {"upgrade"};
      this.Help = "Usage: composer4d update";
      this.Description = "The <info>update</info> command reads the composer.json file from the current directory, processes it, and updates, removes or installs all the dependencies.";
    }

    public string run(string[] arguments)
    {
      this.configure();
      return this.help;
    }
  }
}