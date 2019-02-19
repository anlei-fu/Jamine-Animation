using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Jasmine.Animation
{
    public  class TimeAnimator : IAnimator,IDisposable
    {
        private bool _disposed;
        private Timer _timer;
        public bool IsAvailable { get; private set; } = true;
        public void Animate(int duration,int fps ,IAnimateHandler handler, Action onFinished,AnimateFunctionType animateFunctionType)
        {
            if (!IsAvailable)
                return;

          var  start = DateTime.Now;
          var  end = DateTime.Now.AddMilliseconds(duration);

            if (_timer == null)
            {
                _timer = new Timer();

                _timer.Tick += (x, y) =>
                  {
                      if(DateTime.Now>end)
                      {
                          handler.OnAnimate(AnimateFunction.Caculate(animateFunctionType,1f));
                          onFinished?.Invoke();
                          _timer.Enabled = false;
                          IsAvailable = true;
                      }
                      else
                      {

                          var total = (DateTime.Now - start).TotalMilliseconds;
                          var rate= (float)(DateTime.Now - start).TotalMilliseconds/ (float)duration;
                          Trace.Write($"  time:{DateTime.Now}        total:{total}    duration:{duration} rate:{rate}\r\n");
                          handler?.OnAnimate(AnimateFunction.Caculate(animateFunctionType,rate));
                      }
                  };

            }

            _timer.Interval =(int) (1000 / (float)fps);
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
