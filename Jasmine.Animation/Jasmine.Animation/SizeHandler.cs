using System;
using System.Drawing;

namespace Jasmine.Animation

{
    public class SizeHandler : AbstractAnimateHandler<Size>
    {
        public SizeHandler(Size start, Size end, Action<Size> onAnimate) : base(start, end, onAnimate)
        {
        }

        protected override Size caculate(float t)
        {
            var w = Start.Width + (int)((End.Width - Start.Width) * t);
            w = w < 0 ? 0 : w;
            var h = Start.Height + (int)((End.Height - Start.Height) * t);
            h = h < 0 ? 0 : h;

            return new Size(w,h );
        }
    }
}
