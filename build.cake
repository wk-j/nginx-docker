#addin "wk.StartProcess"

using PS = StartProcess.Processor;

var name = "MyApp";
var project = $"src/{name}/{name}.csproj";

Task("Publish").Does(() => {
    DotNetCorePublish(project, new DotNetCorePublishSettings {
        OutputDirectory = "publish"
    });
});

Task("Start-Docker")
    .IsDependentOn("Publish")
    .Does(() => {

        PS.StartProcess("docker-compose down");
        PS.StartProcess("docker-compose build");
        PS.StartProcess("docker-compose up");
    });

var target = Argument("target", "default");
RunTarget(target);