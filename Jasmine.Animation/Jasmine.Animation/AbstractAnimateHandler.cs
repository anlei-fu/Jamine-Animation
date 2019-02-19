using System;

namespace Jasmine.Animation
{
    public abstract  class AbstractAnimateHandler<T>:IAnimateHandler
    {
        public  AbstractAnimateHandler(T start,T end,Action<T> onAnimate)
        {
            Start = start;
            End = end;
            _callBack = onAnimate;
        }

        private Action<T> _callBack;
        public T Start { get; set; }
        public T End { get; set; }

        protected abstract T caculate(float t);

        public void OnAnimate( float t)
        {
            _callBack?.Invoke(caculate(t));
        }
    }
}
