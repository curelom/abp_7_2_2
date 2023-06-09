using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace abp_7_2_2.MauiBlazor;

internal class Program : MauiApplication
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    static void Main(string[] args)
    {
        var app = new Program();
        app.Run(args);
    }
}
