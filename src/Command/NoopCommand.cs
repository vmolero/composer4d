using System;
using System.Collections.Generic;

namespace Command
{
  public class NoopCommand : BaseCommand, Runnable
  {
    public override void configure()
    {
      this.Name = "No op";
      this.Aliases = new string[] {""};
      this.Description = "No op command";
    }

    public string run(string[] arguments)
    {
      return this.Help;
    }
  }
}