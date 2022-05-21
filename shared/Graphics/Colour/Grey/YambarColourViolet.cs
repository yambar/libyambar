using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Grey;

public class YambarColourViolet : IGreyColorPalette
{
    public virtual Colour4 Origin => Colour4.FromHex("#BF04FF");

    public virtual Colour4 Lighter => Colour4.FromHex("#EBB8FE");
    public virtual Colour4 Light => Colour4.FromHex("#685370");
    public virtual Colour4 Base => Colour4.FromHex("#46334D");
    public virtual Colour4 Dark => Colour4.FromHex("#2C2230");
    public virtual Colour4 Darker => Colour4.FromHex("#201823");
}
