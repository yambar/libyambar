using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Grey;

public class YambarColourCyan : IGreyColorPalette
{
    public virtual Colour4 Origin => Colour4.FromHex("#05F4FD");

    public virtual Colour4 Lighter => Colour4.FromHex("#77B1B3");
    public virtual Colour4 Light => Colour4.FromHex("#436D6F");
    public virtual Colour4 Base => Colour4.FromHex("#293D3E");
    public virtual Colour4 Dark => Colour4.FromHex("#243536");
    public virtual Colour4 Darker => Colour4.FromHex("#1E2929");
}
