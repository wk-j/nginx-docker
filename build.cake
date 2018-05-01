#addin "wk.StartProcess"

using PS = StartProcess.Processor;


Task("Start-Docker").Does(() => {
    PS.StartProcess("docker-compose down");
    PS.StartProcess("docker-compose up");
});

var target = Argument("target", "default");
RunTarget(target);