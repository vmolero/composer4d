using System;

namespace Command
{
  public abstract class BaseCommand : Configurable
  {
    protected string name;
    public string Name {
      set { name = value.ToLower(); }
    }
    protected string help;
    public string Help {
      set { help = value; }
    }
    protected string[] aliases;
    public string[] Aliases {
      set { aliases = value; }
    }
    protected string[] definition;
    public string[] Definition {
      set { definition = value; }
    }
    protected string description;
    public string Description {
      set { description = value; }
    }
    public abstract void configure();
  }
}