using System.Collections.Generic;

namespace Jasmine.Animation
{
    public class AnimateHandlerGroup : IAnimateHandler
    {
        public AnimateHandlerGroup(IEnumerable<IAnimateHandler> handlers)
        {
            foreach (var item in handlers)
                _hanlers.Add(item);
        }
        private IList<IAnimateHandler> _hanlers = new List<IAnimateHandler>();
        public void OnAnimate(float t)
        {
            foreach (var item in _hanlers)
                item.OnAnimate(t);
        }
    }
}
