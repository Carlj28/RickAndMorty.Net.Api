//------------------------------------------------------
//Get version from .csproj
using System.Text.RegularExpressions;

public static string ReadVersionNumberFromProject(ICakeContext context)
{
    var file = context.GetFiles(Variables.ProjectFile.ToString()).First();
    var project = ReadFile(file);
    return ParseVersionNumber(project);
}

public static string ReadFile(FilePath path) => System.IO.File.ReadAllText(path.FullPath, Encoding.UTF8);

public static string ParseVersionNumber(string project)
{
    var versionPattern = new Regex("<Version>(?<version>.*)</Version>");
    return versionPattern.Match(project).Groups["version"].Value;
}