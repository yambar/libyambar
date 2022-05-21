namespace yambar.Tests.Visual;

public class ApplicationTestSceneTestRunner : TestApplication, ITestSceneTestRunner
{
    private TestSceneTestRunner.TestRunner runner;

    protected override void LoadAsyncComplete()
    {
        base.LoadAsyncComplete();

        Add(runner = new TestSceneTestRunner.TestRunner());
    }

    public void RunTestBlocking(TestScene test)
        => runner.RunTestBlocking(test);
}
