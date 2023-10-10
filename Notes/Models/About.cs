namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://career.severstal.com/directions/graduates/it_hub/?utm_source=online&utm_medium=internal&utm_campaign=references";
    public string Message => "Сделано с использованием .NET MAUI.";
}