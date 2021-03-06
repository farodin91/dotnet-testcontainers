namespace DotNet.Testcontainers.Containers.WaitStrategies.Windows
{
  internal class UntilCommandIsCompleted : Unix.UntilCommandIsCompleted
  {
    public UntilCommandIsCompleted(string command) : base("PowerShell", "-Command", command)
    {
    }

    public UntilCommandIsCompleted(params string[] command) : base(command)
    {
    }
  }
}
