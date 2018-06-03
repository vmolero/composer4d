using System;

namespace Command
{
  public class UpdateCommand : BaseCommand, Runnable
  {
    public override void configure()
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