using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Generics;

public class YambarColourYellow : IGenericColorPalette
{
    public virtual Colour4 Lighter => Colour4.FromHex("#FFFFDD");
    public virtual Colour4 Light => Colour4.FromHex("#FFDD55");
    public virtual Colour4 Base => Colour4.FromHex("#FFCC22");
    public virtual Colour4 Dark => Colour4.FromHex("#EEAA00");
    public virtual Colour4 Darker => Colour4.FromHex("#CC6600");
}
