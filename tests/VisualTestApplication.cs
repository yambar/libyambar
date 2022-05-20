using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Cursor;
using osu.Framework.Platform;

namespace yambar.Tests;

public class VisualTestApplication : TestApplicaton
{
    [BackgroundDependencyLoader]
    private void load()
    {
        Child = new SafeAreaContainer
        {
            RelativeSizeAxes = Axes.Both,
            Child = new DrawSizePreservingFillContainer
            {
                Children = new Drawable[]
                {
                    new TestBrowser("yambar"),
                    new CursorContainer(),
                }
            }
        };
    }

    public override void SetHost(GameHost host)
    {
        base.SetHost(host);

        host.Window.CursorState |= CursorState.Hidden;
    }
}
