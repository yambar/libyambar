global using osu.Framework.Allocation;
global using osu.Framework.Bindables;
global using osu.Framework.Graphics;
global using osu.Framework.Testing;

global using osuTK;

using ofApplication = osu.Framework.Game;

namespace yambar.Tests;

[Cached]
public class TestApplication : ofApplication
{
    public Bindable<bool> BlockExit => new();

    protected override bool OnExiting()
        => BlockExit.Value;
}
