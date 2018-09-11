//Load script containing variables
#load variables.cake

#load versioning.cake

var target = Argument("Target", "Build");

var configuration = Argument("Configuration", "Release");

var packageOutputPath = Argument<DirectoryPath>("PackageOutputPath", "packages");
var publishOutputPath = Argument<DirectoryPath>("PublishOutputPath", "publish");

var packagePath = File("RandomRickAndMortyFacts.zip").Path;

var packageVersion = "0.1.0";

//------------------------------------------------------
//Net Core

Task("Build")
	.IsDependentOn("Restore")
	.IsDependentOn("RunTests")
	.IsDependentOn("Version")
	.Does(() => {
		//Net Core build

		DotNetCoreBuild(Paths.SolutionFile.ToString(),
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
	.IsDependentOn("Build")	
	.IsDependentOn("RemovePackages")
	.Does(() => {

		EnsureDirectoryExists(packageOutputPath);

		DotNetCorePack(Paths.ProjectDirectory.ToString(),
			new DotNetCorePackSettings{
					Configuration = configuration,
					OutputDirectory = packageOutputPath
				});
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
	DotNetCoreTest(Paths.TestProjectDir.ToString());
});

RunTarget(target);