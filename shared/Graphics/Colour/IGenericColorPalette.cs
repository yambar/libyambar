using osu.Framework.Graphics;

namespace yambar.Graphics.Colour;

public interface IGenericColorPalette
{
    Colour4 Lighter { get; }
    Colour4 Light { get; }
    Colour4 Base { get; }
    Colour4 Dark { get; }
    Colour4 Darker { get; }
}
