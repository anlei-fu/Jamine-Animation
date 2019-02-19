using System;

namespace Jasmine.Animation
{
    public class IntHandler : AbstractAnimateHandler<int>
    {
        public IntHandler(int start, int end, Action<int> onAnimate) : base(start, end, onAnimate)
        {
        }
        protected override int caculate(float t)
        {
            return Start + (int)((End - Start) * t);
        }
    }
}
