using System;

namespace Jasmine.Animation
{
    public  interface IAnimator
    {
        void Animate(int duration,int fps, IAnimateHandler handler,Action onFinished,AnimateFunctionType animateFunctionType );
        bool IsAvailable { get; }
    }
}
