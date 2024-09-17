using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;

using System.Diagnostics;

namespace SKT.Extensions
{
    public static class ApplicationExtensions
    {
        public static Window GetMainWindow(this Application app)
        {
            if (app.ApplicationLifetime is not IClassicDesktopStyleApplicationLifetime window)
                throw new UnreachableException();

            return window.MainWindow!;
        }
    }
}