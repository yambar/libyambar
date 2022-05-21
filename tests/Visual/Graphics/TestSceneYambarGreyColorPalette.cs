using NUnit.Framework;

using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;

using System.Collections.Generic;

using yambar.Graphics.Colour;
using yambar.Graphics.Colour.Grey;

namespace yambar.Tests.Visual.Graphics;

public class TestSceneYambarGreyColorPalette : ApplicationTestScene
{
    [Test]
    public void TestYambarCarmineColour()
    {
        addClearStep();
        addColorsStep(new YambarColourCarmine());
    }

    [Test]
    public void TestYambarCyanColour()
    {
        addClearStep();
        addColorsStep(new YambarColourCyan());
    }

    [Test]
    public void TestYambarLimeColour()
    {
        addClearStep();
        addColorsStep(new YambarColourLime());
    }

    [Test]
    public void TestYambarSeafoamColour()
    {
        addClearStep();
        addColorsStep(new YambarColourSeafoam());
    }

    [Test]
    public void TestYambarSkyColour()
    {
        addClearStep();
        addColorsStep(new YambarColourSky());
    }

    [Test]
    public void TestYambarVioletColour()
    {
        addClearStep();
        addColorsStep(new YambarColourViolet());
    }

    private void addClearStep()
        => AddStep("clear contents", () => Clear());

    private void addColorsStep(IGreyColorPalette palette)
        => AddStep("draw palette", () =>
        {
            var fill = new FillFlowContainer<Container>
            {
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                AutoSizeAxes = Axes.Both,
                Spacing = new Vector2(24.0f),
                Direction = FillDirection.Horizontal
            };
            var containers = new List<Container>();
            var boxes = new List<Box>();

            for (var i = 0; i < 6; i++)
            {
                containers.Add(createContainer());
                containers[i].Child = createBox();
            }

            containers[0].Child.Colour = palette.Origin;
            containers[1].Child.Colour = palette.Lighter;
            containers[2].Child.Colour = palette.Light;
            containers[3].Child.Colour = palette.Base;
            containers[4].Child.Colour = palette.Dark;
            containers[5].Child.Colour = palette.Darker;

            foreach (var container in containers)
                fill.Add(container);

            Add(fill);
        });

    private Box createBox()
        => new()
        {
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            Size = new Vector2(100.0f),
        };

    private Container createContainer()
        => new()
        {
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            AutoSizeAxes = Axes.Both
        };
}
