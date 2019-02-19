using System;
using System.Windows.Forms;

namespace Jasmine.Animation
{
    public class TimeAnimator : IAnimator, IDisposable
    {
        private bool _disposed;
        private Timer _timer;
        public bool IsAvailable { get; private set; } = true;
        public void Animate(int duration, int fps, IAnimateHandler handler, Action onFinished, AnimateFunctionType funcType)
        {
            if (_disposed || !IsAvailable)
                return;

            var start = DateTime.Now;
            var end = DateTime.Now.AddMilliseconds(duration);

            if (_timer == null)
            {
                _timer = new Timer();

                _timer.Tick += (x, y) =>
                  {
                      if (DateTime.Now > end)
                      {
                          handler.OnAnimate(AnimateFunction.Caculate(funcType, 1f));
                          onFinished?.Invoke();
                          _timer.Enabled = false;
                          IsAvailable = true;
                      }
                      else
                      {
                          handler?.OnAnimate(AnimateFunction.Caculate(funcType, (float)(DateTime.Now - start).TotalMilliseconds / (float)duration));
                      }
                  };

            }

            _timer.Interval = (int)(1000 / (float)fps);
            IsAvailable = false;
            _timer.Enabled = true;

        }
        public void Dispose()
        {
            if (!_disposed)
            {
                _timer.Dispose();
                _disposed = true;
            }
        }
    }
}
