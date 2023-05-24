namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://github.com/emirhandemirden";
    public string Message => "This app is written in XAML and C# with .NET MAUI. This app is made to help you write and save your notes on your phone without any hassle.";
}