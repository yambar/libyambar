using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Generics;

public class YambarColourRed : IGenericColorPalette
{
    public virtual Colour4 Lighter => Colour4.FromHex("#FFEDED");
    public virtual Colour4 Light => Colour4.FromHex("#ED7787");
    public virtual Colour4 Base => Colour4.FromHex("#ED1121");
    public virtual Colour4 Dark => Colour4.FromHex("#BA0011");
    public virtual Colour4 Darker => Colour4.FromHex("#870000");
}
