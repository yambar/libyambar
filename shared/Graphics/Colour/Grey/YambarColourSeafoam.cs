using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Grey;

public class YambarColourSeafoam : IGreyColorPalette
{
    public virtual Colour4 Origin => Colour4.FromHex("#05FFA2");

    public virtual Colour4 Lighter => Colour4.FromHex("#9EBAB1");
    public virtual Colour4 Light => Colour4.FromHex("#4D7365");
    public virtual Colour4 Base => Colour4.FromHex("#33413C");
    public virtual Colour4 Dark => Colour4.FromHex("#2C3532");
    public virtual Colour4 Darker => Colour4.FromHex("#1E2422");
}
