using osu.Framework.Graphics;

namespace yambar.Graphics.Colour;

/// <summary>
/// A color palette with grayscales, from <see cref="Zero"/> to <see cref="F"/>.
/// </summary>
public interface IGrayScaleColorPalette
{
    Colour4 Zero { get; }
    Colour4 One { get; }
    Colour4 Two { get; }
    Colour4 Three { get; }
    Colour4 Four { get; }
    Colour4 Five { get; }
    Colour4 Six { get; }
    Colour4 Seven { get; }
    Colour4 Eight { get; }
    Colour4 Nine { get; }
    Colour4 A { get; }
    Colour4 B { get; }
    Colour4 C { get; }
    Colour4 D { get; }
    Colour4 E { get; }
    Colour4 F { get; }
}
