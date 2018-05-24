using System;

namespace Command
{
    public class CommandBase
    {   
        // System.AppContext;
        // EnvironmentVariableTarget
        private const int MIN_ARGS = 2;
        public string run(string[] arguments) {
            string command = "";
            if (arguments.Length < MIN_ARGS) {
                return this.getHelp();
            }
            switch (arguments[1].ToLower())
            {
                case "update":
                    command = "update";
                    break;
                default:
                    return this.getHelp();
            }
            return command;
        }

    private string getHelp()
    {
      return "Usage: composer4d <command> [options]";
    }

    public string sayHi(string name) {
            return "Hi " + name;
        }
    }
}
