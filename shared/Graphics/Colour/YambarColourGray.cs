using osu.Framework.Graphics;

namespace yambar.Graphics.Colour;

public class YambarColourGray : IGrayScaleColorPalette
{
    public virtual Colour4 Zero => Colour4.FromHex("#000000");
    public virtual Colour4 One => Colour4.FromHex("#111111");
    public virtual Colour4 Two => Colour4.FromHex("#222222");
    public virtual Colour4 Three => Colour4.FromHex("#333333");
    public virtual Colour4 Four => Colour4.FromHex("#444444");
    public virtual Colour4 Five => Colour4.FromHex("#555555");
    public virtual Colour4 Six => Colour4.FromHex("#666666");
    public virtual Colour4 Seven => Colour4.FromHex("#777777");
    public virtual Colour4 Eight => Colour4.FromHex("#888888");
    public virtual Colour4 Nine => Colour4.FromHex("#999999");

    public virtual Colour4 A => Colour4.FromHex("#AAAAAA");
    public virtual Colour4 B => Colour4.FromHex("#BBBBBB");
    public virtual Colour4 C => Colour4.FromHex("#CCCCCC");
    public virtual Colour4 D => Colour4.FromHex("#DDDDDD");
    public virtual Colour4 E => Colour4.FromHex("#EEEEEE");
    public virtual Colour4 F => Colour4.FromHex("#FFFFFF");
}
