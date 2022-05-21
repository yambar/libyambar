using osu.Framework.Graphics;

namespace yambar.Graphics.Colour;

/// <summary>
/// A grayscale color palette, containing the source color for all colors.
/// </summary>
public interface IGreyColorPalette : IGenericColorPalette
{
    Colour4 Origin { get; }
}
