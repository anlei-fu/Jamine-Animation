using System;

namespace Jasmine.Animation
{
    public class FloatHandler : AbstractAnimateHandler<float>
    {
        public FloatHandler(float start, float end, Action<float> onAnimate) : base(start, end, onAnimate)
        {
        }
        protected override float caculate(float t)
        {
            return Start + (End - Start) * t;
        }
    }
}
