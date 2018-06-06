using DocoptNet;
using System.Collections.Generic;

namespace Command {
  public class CommandParser : Docopt
  {
    protected Docopt opt;
    protected string version;

    public CommandParser(string version)
    {
      this.opt = new Docopt();
      this.version = version;
    }
    
    public IDictionary<string, ValueObject> Apply(string doc, string[] arguments) 
    {
      IList<string> argumentList = new List<string>();
      foreach (string argument in arguments) {
        argumentList.Add(argument);
      }
      return this.opt.Apply(doc, argumentList, help: true, version: "Composer4D v" + this.version, exit: false);
    }
  }
}