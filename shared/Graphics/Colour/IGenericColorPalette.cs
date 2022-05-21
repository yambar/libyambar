using osu.Framework.Graphics;

namespace yambar.Graphics.Colour;

/// <summary>
/// A generic color palette, from the lightest to the darkest color.
/// </summary>
public interface IGenericColorPalette
{
    /// <summary>
    /// The lightest color in the palette.
    /// </summary>
    Colour4 Lighter { get; }

    /// <summary>
    /// The light color of the palette.
    /// </summary>
    Colour4 Light { get; }

    /// <summary>
    /// The base color of the palette.
    /// </summary>
    Colour4 Base { get; }

    /// <summary>
    /// The dark color of the palette.
    /// </summary>
    Colour4 Dark { get; }

    /// <summary>
    /// The darkest color in the palette.
    /// </summary>
    Colour4 Darker { get; }
}
