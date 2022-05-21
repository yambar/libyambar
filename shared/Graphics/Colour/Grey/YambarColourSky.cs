using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Grey;

public class YambarColourSky : IGreyColorPalette
{
    public virtual Colour4 Origin => Colour4.FromHex("#6BB5FF");

    public virtual Colour4 Lighter => Colour4.FromHex("#C6E3F4");
    public virtual Colour4 Light => Colour4.FromHex("#8AB3CC");
    public virtual Colour4 Base => Colour4.FromHex("#405461");
    public virtual Colour4 Dark => Colour4.FromHex("#303D47");
    public virtual Colour4 Darker => Colour4.FromHex("#21272C");
}
