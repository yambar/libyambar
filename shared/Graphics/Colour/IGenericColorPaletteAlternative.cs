using osu.Framework.Graphics;

namespace yambar.Graphics.Colour;

/// <summary>
/// A generic color palette, containing alternatives to light and dark colors.
/// </summary>
public interface IGenericColorPaletteAlternative : IGenericColorPalette
{
    /// <summary>
    /// The alternate light color from the palette.
    /// </summary>
    Colour4 LightAlternative { get; }

    /// <summary>
    /// The alternate dark color from the palette.
    /// </summary>
    Colour4 DarkAlternative { get; }
}
