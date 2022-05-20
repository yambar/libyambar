namespace yambar.Tests.Visual;

public class ApplicationTestScene : TestScene
{
    protected override ITestSceneTestRunner CreateRunner()
        => new ApplicationTestSceneTestRunner();
}
