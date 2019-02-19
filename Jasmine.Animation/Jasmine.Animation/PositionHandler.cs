using System;
using System.Drawing;

namespace Jasmine.Animation
{
    public class PositionHandler : AbstractAnimateHandler<Point>
    {
        public PositionHandler(Point start, Point end, Action<Point> onAnimate) : base(start, end, onAnimate)
        {
        }
        protected override Point caculate(float t)
        {
            return new Point(Start.X + (int)((End.X - Start.X) * t), Start.Y + (int)((End.Y - Start.Y) * t));
        }
    }
}
