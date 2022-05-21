using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Generics;

public class YambarColourGreen : IGenericColorPalette
{
    public virtual Colour4 Lighter => Colour4.FromHex("#EEFFCC");
    public virtual Colour4 Light => Colour4.FromHex("#B3D944");
    public virtual Colour4 Base => Colour4.FromHex("#88B300");
    public virtual Colour4 Dark => Colour4.FromHex("#668800");
    public virtual Colour4 Darker => Colour4.FromHex("#445500");
}
