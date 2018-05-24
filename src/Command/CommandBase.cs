using System;

namespace Command
{
    public class CommandBase
    {
        public void run(string[] arguments) {
            this.sayHi(arguments[1]);            
        }

        public string sayHi(string name) {
            return "Hi " + name;
        }
    }
}
