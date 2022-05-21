using NUnit.Framework;

using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;

using System.Collections.Generic;

using yambar.Graphics.Colour;
using yambar.Graphics.Colour.Generics;

namespace yambar.Tests.Visual.Graphics;

public class TestSceneYambarGenericColorPalette : ApplicationTestScene
{
    [Test]
    public void TestYambarPurpleColour()
    {
        addClearStep();
        addColorsStep(new YambarColourPurple());
    }

    [Test]
    public void TestYambarRedColour()
    {
        addClearStep();
        addColorsStep(new YambarColourRed());
    }

    [Test]
    public void TestYambarPinkColour()
    {
        addClearStep();
        addColorsStep(new YambarColourPink());
    }

    [Test]
    public void TestYambarGreenColour()
    {
        addClearStep();
        addColorsStep(new YambarColourGreen());
    }

    [Test]
    public void TestYambarBlueColour()
    {
        addClearStep();
        addColorsStep(new YambarColourBlue());
    }

    [Test]
    public void TestYambarYellowColour()
    {
        addClearStep();
        addColorsStep(new YambarColourYellow());
    }

    private void addClearStep()
        => AddStep("clear contents", () => Clear());

    private void addColorsStep(IGenericColorPalette palette)
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

            for (var i = 0; i < 5; i++)
            {
                containers.Add(createContainer());
                containers[i].Child = createBox();
            }

            containers[0].Child.Colour = palette.Lighter;
            containers[1].Child.Colour = palette.Light;
            containers[2].Child.Colour = palette.Base;
            containers[3].Child.Colour = palette.Dark;
            containers[4].Child.Colour = palette.Darker;

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
