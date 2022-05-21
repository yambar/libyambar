using osu.Framework.Graphics;

namespace yambar.Graphics.Colour.Generics;

public class YambarColourPurple : IGenericColorPaletteAlternative
{
    public virtual Colour4 Lighter => Colour4.FromHex("#EEEEFF");
    public virtual Colour4 Light => Colour4.FromHex("#AA88FF");
    public virtual Colour4 Base => Colour4.FromHex("#8866EE");
    public virtual Colour4 Dark => Colour4.FromHex("#6644CC");
    public virtual Colour4 Darker => Colour4.FromHex("#441188");

    public virtual Colour4 LightAlternative => Colour4.FromHex("#CBA4DA");
    public virtual Colour4 DarkAlternative => Colour4.FromHex("#312436");
}
