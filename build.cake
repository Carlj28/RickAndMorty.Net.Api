//Load script containing variables
#load variables.cake

#load versioning.cake

var target = Argument("Target", "Build");

var configuration = Argument("Configuration", "Release");

//var nuGetKey = Argument("NuGetKey", "");
var packageOutputPath = Argument<DirectoryPath>("PackageOutputPath", "packages");
var publishOutputPath = Argument<DirectoryPath>("PublishOutputPath", "publish");

var packageVersion = "0.1.0";

//------------------------------------------------------
//Net Core

Task("Build")
	.IsDependentOn("Restore")
	.IsDependentOn("RunTests")
	.IsDependentOn("Version")
	.Does(() => {
		//Net Core build

		DotNetCoreBuild(Variables.SolutionFile.ToString(),
					new DotNetCoreBuildSettings {
							Configuration = configuration
						});

		});

Task("Restore")
	.Does(() => {
		//Restore nuget packages

		DotNetCoreRestore();

	});

//------------------------------------------------------
//Nuget packages

Task("RemovePackages")
	.Does(() => {
		CleanDirectory(packageOutputPath);
	});

Task("CreateNugetPackages")
	.IsDependentOn("RunTests")
	.IsDependentOn("RemovePackages")
	.Does(() => {

		EnsureDirectoryExists(packageOutputPath);

		DotNetCorePack(Variables.ProjectDirectory.ToString(),
			new DotNetCorePackSettings{
					Configuration = configuration,
					OutputDirectory = packageOutputPath
				});
	});

Task("PushPackage")
.IsDependentOn("CreateNugetPackages")
.Does(() => {
	var key = EnvironmentVariable("NugetKey");

	if(String.IsNullOrEmpty(key))
		return;
	else
		Information($"Loaded nuget key.");

	foreach(var file in GetFiles($"{packageOutputPath}/*.nupkg"))
	{
		Information($"---###---");
		Information($"Publising file: {file.FullPath}");

		DotNetCoreNuGetPush(file.FullPath, new DotNetCoreNuGetPushSettings {
			Source = Variables.NugetSource,
			ApiKey = key
		});

		Information("File published!");
	}
});

//------------------------------------------------------
//Versioning

Task("Version")
	.Does(() => {
		packageVersion = ReadVersionNumberFromProject(Context);
		Information("Version from .csproj file: "+ packageVersion);
	});

//------------------------------------------------------
//NET Core

Task("RunTests")
	.IsDependentOn("Restore")
	.Does(() => 
{
	//DotNetCoreTest automaticly builds solution so you don't need to depend on build task
	DotNetCoreTest(Variables.TestProjectDir.ToString());
});

RunTarget(target);