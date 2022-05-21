using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Grey;

public class YambarColourLime : IGreyColorPalette
{
    public virtual Colour4 Origin => Colour4.FromHex("#82FF05");

    public virtual Colour4 Lighter => Colour4.FromHex("#DEFF87");
    public virtual Colour4 Light => Colour4.FromHex("#657259");
    public virtual Colour4 Base => Colour4.FromHex("#3F443A");
    public virtual Colour4 Dark => Colour4.FromHex("#32352E");
    public virtual Colour4 Darker => Colour4.FromHex("#2E302B");
}
