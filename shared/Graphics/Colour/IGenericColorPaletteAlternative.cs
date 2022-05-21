using osu.Framework.Graphics;

namespace yambar.Graphics.Colour;

public interface IGenericColorPaletteAlternative : IGenericColorPalette
{
    Colour4 LightAlternative { get; }
    Colour4 DarkAlternative { get; }
}
