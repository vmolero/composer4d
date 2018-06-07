using System;
using System.Collections.Generic;

namespace Command
{
  public class InitCommand : BaseCommand, Runnable
  {
    public override void configure()
    {
      this.Name = "Init";
      this.Aliases = new string[] {""};
      this.Description = "Init command";
    }

    public string run(string[] arguments)
    {
      return this.Description;
    }
  }
}