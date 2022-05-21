using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Generics;

public class YambarColourBlue : IGenericColorPalette
{
    public virtual Colour4 Lighter => Colour4.FromHex("#DDFFFF");
    public virtual Colour4 Light => Colour4.FromHex("#99EEFF");
    public virtual Colour4 Base => Colour4.FromHex("#66CCFF");
    public virtual Colour4 Dark => Colour4.FromHex("#44AADD");
    public virtual Colour4 Darker => Colour4.FromHex("#2299BB");
}
