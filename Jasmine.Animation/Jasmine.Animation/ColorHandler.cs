using System.Drawing;

namespace Jasmine.Animation
{
    public class ColorHandler : AbstractAnimateHandler<Color>
    {
        public ColorHandler(Color start, Color end, System.Action<Color> onAnimate) : base(start, end, onAnimate)
        {
        }
        protected override Color caculate(float t)
        {
            var a = Start.A + (int)((End.A - Start.A) * t);
            var r = Start.R + (int)((End.R - Start.R) * t);
            var g = Start.G + (int)((End.G - Start.G) * t);
            var b = Start.B + (int)((End.B - Start.B) * t);

            a = a > 255 ? 255 : a < 0 ? 0 : a;
            r = r > 255 ? 255 : r < 0 ? 0 : r;
            g = g > 255 ? 255 : g < 0 ? 0 : g;
            b = b > 255 ? 255 : b < 0 ? 0 : b;

            return Color.FromArgb(a, r, g, b);
        }
    }
}
