using ADotNet.Clients;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.SetupDotNetTaskV1s;

var githubPipeline = new GithubPipeline
{
    Name = "HouseForRent Pipeline",
    OnEvents = new Events
    {
        PullRequest = new PullRequestEvent
        {
            Branches = new[] { "master" }
        },
        Push = new PushEvent
        {
            Branches = new[] { "master" }
        }
    },
    Jobs = new Dictionary<string, Job>
    {
        {
            "build",
            new Job
            {
                RunsOn = BuildMachines.Windows2022,
                Steps = new List<GithubTask>
                {
                    new CheckoutTaskV2
                    {
                        Name = "Checking Out Code"
                    },
                    new SetupDotNetTaskV1
                    {
                        Name = "Setting Up .NET",
                        TargetDotNetVersion = new TargetDotNetVersion
                        {
                            DotNetVersion = "7.0.400"
                        }
                    },
                    new RestoreTask
                    {
                        Name = "Restoring Nuget Packages"
                    },
                    new DotNetBuildTask
                    {
                        Name = "Building Project"
                    },
                    new TestTask
                    {
                        Name = "Running Tests"
                    }
                }
            }
        }
    }
};


var client = new ADotNetClient();

client.SerializeAndWriteToFile(
    adoPipeline:githubPipeline,
    path:"../../../../.github/workflows/dotnet.yml");
