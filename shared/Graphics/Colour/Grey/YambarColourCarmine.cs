using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Grey;

public class YambarColourCarmine : IGreyColorPalette
{
    public virtual Colour4 Origin => Colour4.FromHex("#FF0542");

    public virtual Colour4 Lighter => Colour4.FromHex("#DEAAB4");
    public virtual Colour4 Light => Colour4.FromHex("#644F53");
    public virtual Colour4 Base => Colour4.FromHex("#342B2D");
    public virtual Colour4 Dark => Colour4.FromHex("#302A2B");
    public virtual Colour4 Darker => Colour4.FromHex("#241D1E");
}
