using System;
using osu.Framework;

namespace yambar.Tests;

public static class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        using var host = Host.GetSuitableDesktopHost(@"visual-tests", new HostOptions
        {
            PortableInstallation = true
        });
        using var application = new VisualTestApplication();

        host.Run(application);
    }
}
