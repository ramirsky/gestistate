using Smusdi.Testing;
using TechTalk.SpecFlow;

namespace gestistate.Testing;

[Binding]
public sealed class ApiHook
{
    private readonly SmusdiServiceTestingSteps smusdiServiceTestingSteps;

    public ApiHook(SmusdiServiceTestingSteps smusdiServiceTestingSteps) => this.smusdiServiceTestingSteps = smusdiServiceTestingSteps;

    [BeforeScenario("api")]
    public Task InitializeAndStartService() => this.smusdiServiceTestingSteps.GivenTheServiceInitializedAndStarted();
}
