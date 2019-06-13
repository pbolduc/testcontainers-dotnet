namespace DotNet.Testcontainers.Core.Wait
{
  public static class Wait
  {
    public static IWaitUntil UntilContainerIsRunning()
    {
      return new WaitUntilContainerIsRunning();
    }

    public static IWaitUntil UntilFileExists(string file)
    {
      return new WaitUntilFileExists(file);
    }

    public static IWaitUntil UntilPortIsAvailable(int port)
    {
      return new WaitUntilPortIsAvailable(port);
    }
  }
}