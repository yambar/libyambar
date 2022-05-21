using NUnit.Framework;

using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;

using System.Collections.Generic;

using yambar.Graphics.Colour;
using yambar.Graphics.Colour.Grey;

namespace yambar.Tests.Visual.Graphics;

public class TestSceneYambarGrayScaleColorPalette : ApplicationTestScene
{
    [Test]
    public void TestYambarGrayColour()
    {
        addClearStep();
        addColorsStep(new YambarColourGray());
    }

    private void addClearStep()
        => AddStep("clear contents", () => Clear());

    private void addColorsStep(IGrayScaleColorPalette palette)
        => AddStep("draw palette", () =>
        {
            var fill = new FillFlowContainer<Container>
            {
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                RelativeSizeAxes = Axes.Both,
                Size = new Vector2(1.0f),
                Spacing = new Vector2(24.0f),
                Direction = FillDirection.Full
            };
            var containers = new List<Container>();
            var boxes = new List<Box>();

            for (var i = 0; i < 16; i++)
            {
                containers.Add(createContainer());
                containers[i].Child = createBox();
            }

            containers[0].Child.Colour = palette.Zero;
            containers[1].Child.Colour = palette.One;
            containers[2].Child.Colour = palette.Two;
            containers[3].Child.Colour = palette.Three;
            containers[4].Child.Colour = palette.Four;
            containers[5].Child.Colour = palette.Five;
            containers[6].Child.Colour = palette.Six;
            containers[7].Child.Colour = palette.Seven;
            containers[8].Child.Colour = palette.Eight;
            containers[9].Child.Colour = palette.Nine;

            containers[10].Child.Colour = palette.A;
            containers[11].Child.Colour = palette.B;
            containers[12].Child.Colour = palette.C;
            containers[13].Child.Colour = palette.D;
            containers[14].Child.Colour = palette.E;
            containers[15].Child.Colour = palette.F;

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
