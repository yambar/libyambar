using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Generics;

public class YambarColourPink : IGenericColorPalette
{
    public virtual Colour4 Lighter => Colour4.FromHex("#FFDDEE");
    public virtual Colour4 Light => Colour4.FromHex("#FF99CC");
    public virtual Colour4 Base => Colour4.FromHex("#FF66AA");
    public virtual Colour4 Dark => Colour4.FromHex("#CC5288");
    public virtual Colour4 Darker => Colour4.FromHex("#BB1177");
}
