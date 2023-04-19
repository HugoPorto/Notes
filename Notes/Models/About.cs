namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://learn.microsoft.com/pt-br/dotnet/maui/tutorials/notes-app/?source=recommendations&view=net-maui-7.0&tutorial-step=4";
    public string Message => "This app is written in XAML and C# with .NET MAUI.";
}
