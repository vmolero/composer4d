using System.Collections.Generic;

namespace Command
{
  public interface Runnable {
    string run(string[] arguments);
  }
}