namespace Command
{
  public interface Configurable
  {
      string Name { set; }
      string[] Aliases { set; }
      string Description { set; }
      string[] Definition { set; }
      string Help { set; }
      void configure();
  }
}