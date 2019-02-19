﻿using System;

namespace Jasmine.Animation
{
    public  class AnimateFunction
    {
        /// <summary>
        /// use a special function to get value of float
        /// </summary>
        /// <param name="type"></param>
        /// <param name="time"> the rate of duration</param>
        /// <returns></returns>
        public static float Caculate(AnimateFunctionType type,float time)
        {
            switch (type)
            {
                case AnimateFunctionType.Linear:
                    return time;
                case AnimateFunctionType.BackEaseIn:
                    return BackEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.BackEaseInOut:
                    return BackEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.BackEaseOut:
                    return BackEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.BackEaseOutIn:
                    return BackEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.BounceEaseIn:
                    return BounceEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.BounceEaseInOut:
                    return BounceEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.BounceEaseOut:
                    return BounceEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.BounceEaseOutIn:
                    return BounceEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.CircEaseIn:
                    return CircEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.CircEaseInOut:
                    return CircEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.CircEaseOut:
                    return CircEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.CircEaseOutIn:
                    return CircEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.CubicEaseIn:
                    return CubicEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.CubicEaseInOut:
                    return CubicEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.CubicEaseOut:
                    return CubicEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.CubicEaseOutIn:
                    return CubicEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.ElasticEaseIn:
                    return ElasticEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.ElasticEaseInOut:
                    return ElasticEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.ElasticEaseOut:
                    return ElasticEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.ElasticEaseOutIn:
                    return ElasticEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.ExpoEaseIn:
                    return ExpoEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.ExpoEaseInOut:
                    return ExpoEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.ExpoEaseOut:
                    return ExpoEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.ExpoEaseOutIn:
                    return ExpoEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.QuadEaseIn:
                    return QuadEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.QuadEaseInOut:
                    return QuadEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.QuadEaseOut:
                    return QuadEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.QuadEaseOutIn:
                    return QuadEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.QuartEaseIn:
                    return QuartEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.QuartEaseInOut:
                    return QuartEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.QuartEaseOut:
                    return QuartEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.QuartEaseOutIn:
                    return QuartEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.QuintEaseIn:
                    return QuintEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.QuintEaseInOut:
                    return QuintEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.QuintEaseOut:
                    return QuintEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.QuintEaseOutIn:
                    return QuintEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.SineEaseIn:
                    return SineEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.SineEaseInOut:
                    return SineEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.SineEaseOut:
                    return SineEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.SineEaseOutIn:
                    return SineEaseOutIn(time, 0, 1, 1);
                default:
                    return time;
            }

        }




        #region Linear  

        /// <summary>  
        /// Easing equation function for a simple linear tweening, with no easing.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float Linear(float t, float b, float c, float d)
        {
            return c * t / d + b;
        }

        #endregion

        #region Expo  

        /// <summary>  
        /// Easing equation function for an exponential (2^t) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float ExpoEaseOut(float t, float b, float c, float d)
        {
            return (t == d) ? b + c : (float)(c * (-Math.Pow(2, -10 * t / d) + 1) + b);
        }

        /// <summary>  
        /// Easing equation function for an exponential (2^t) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float ExpoEaseIn(float t, float b, float c, float d)
        {
            return (t == 0) ? b : (float)(c * Math.Pow(2, 10 * (t / d - 1)) + b);
        }

        /// <summary>  
        /// Easing equation function for an exponential (2^t) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float ExpoEaseInOut(float t, float b, float c, float d)
        {
            if (t == 0)
                return b;

            if (t == d)
                return b + c;

            if ((t /= d / 2) < 1)
                return (float)(c / 2 * Math.Pow(2, 10 * (t - 1)) + b);

            return (float)(c / 2 * (-Math.Pow(2, -10 * --t) + 2) + b);
        }

        /// <summary>  
        /// Easing equation function for an exponential (2^t) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float ExpoEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return ExpoEaseOut(t * 2, b, c / 2, d);

            return ExpoEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Circular  

        /// <summary>  
        /// Easing equation function for a circular (sqrt(1-t^2)) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float CircEaseOut(float t, float b, float c, float d)
        {
            return (float)(c * Math.Sqrt(1 - (t = t / d - 1) * t) + b);
        }

        /// <summary>  
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float CircEaseIn(float t, float b, float c, float d)
        {
            return (float)(-c * (Math.Sqrt(1 - (t /= d) * t) - 1) + b);
        }

        /// <summary>  
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float CircEaseInOut(float t, float b, float c, float d)
        {
            if ((t /= d / 2) < 1)
                return (float)(-c / 2 * (Math.Sqrt(1 - t * t) - 1) + b);

            return (float)(c / 2 * (Math.Sqrt(1 - (t -= 2) * t) + 1) + b);
        }

        /// <summary>  
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float CircEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return CircEaseOut(t * 2, b, c / 2, d);

            return CircEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Quad  

        /// <summary>  
        /// Easing equation function for a quadratic (t^2) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuadEaseOut(float t, float b, float c, float d)
        {
            return -c * (t /= d) * (t - 2) + b;
        }

        /// <summary>  
        /// Easing equation function for a quadratic (t^2) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuadEaseIn(float t, float b, float c, float d)
        {
            return c * (t /= d) * t + b;
        }

        /// <summary>  
        /// Easing equation function for a quadratic (t^2) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuadEaseInOut(float t, float b, float c, float d)
        {
            if ((t /= d / 2) < 1)
                return c / 2 * t * t + b;

            return -c / 2 * ((--t) * (t - 2) - 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a quadratic (t^2) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuadEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return QuadEaseOut(t * 2, b, c / 2, d);

            return QuadEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Sine  

        /// <summary>  
        /// Easing equation function for a sinusoidal (sin(t)) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float SineEaseOut(float t, float b, float c, float d)
        {
            return (float)(c * Math.Sin(t / d * (Math.PI / 2)) + b);
        }

        /// <summary>  
        /// Easing equation function for a sinusoidal (sin(t)) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float SineEaseIn(float t, float b, float c, float d)
        {
            return (float)(-c * Math.Cos(t / d * (Math.PI / 2)) + c + b);
        }

        /// <summary>  
        /// Easing equation function for a sinusoidal (sin(t)) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float SineEaseInOut(float t, float b, float c, float d)
        {
            if ((t /= d / 2) < 1)
                return (float)(c / 2 * (Math.Sin(Math.PI * t / 2)) + b);

            return (float)(-c / 2 * (Math.Cos(Math.PI * --t / 2) - 2) + b);
        }

        /// <summary>  
        /// Easing equation function for a sinusoidal (sin(t)) easing in/out:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float SineEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return SineEaseOut(t * 2, b, c / 2, d);

            return SineEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Cubic  

        /// <summary>  
        /// Easing equation function for a cubic (t^3) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float CubicEaseOut(float t, float b, float c, float d)
        {
            return c * ((t = t / d - 1) * t * t + 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a cubic (t^3) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float CubicEaseIn(float t, float b, float c, float d)
        {
            return c * (t /= d) * t * t + b;
        }

        /// <summary>  
        /// Easing equation function for a cubic (t^3) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float CubicEaseInOut(float t, float b, float c, float d)
        {
            if ((t /= d / 2) < 1)
                return c / 2 * t * t * t + b;

            return c / 2 * ((t -= 2) * t * t + 2) + b;
        }

        /// <summary>  
        /// Easing equation function for a cubic (t^3) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float CubicEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return CubicEaseOut(t * 2, b, c / 2, d);

            return CubicEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Quartic  

        /// <summary>  
        /// Easing equation function for a quartic (t^4) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuartEaseOut(float t, float b, float c, float d)
        {
            return -c * ((t = t / d - 1) * t * t * t - 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a quartic (t^4) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuartEaseIn(float t, float b, float c, float d)
        {
            return c * (t /= d) * t * t * t + b;
        }

        /// <summary>  
        /// Easing equation function for a quartic (t^4) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuartEaseInOut(float t, float b, float c, float d)
        {
            if ((t /= d / 2) < 1)
                return c / 2 * t * t * t * t + b;

            return -c / 2 * ((t -= 2) * t * t * t - 2) + b;
        }

        /// <summary>  
        /// Easing equation function for a quartic (t^4) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuartEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return QuartEaseOut(t * 2, b, c / 2, d);

            return QuartEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Quintic  

        /// <summary>  
        /// Easing equation function for a quintic (t^5) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuintEaseOut(float t, float b, float c, float d)
        {
            return c * ((t = t / d - 1) * t * t * t * t + 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a quintic (t^5) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuintEaseIn(float t, float b, float c, float d)
        {
            return c * (t /= d) * t * t * t * t + b;
        }

        /// <summary>  
        /// Easing equation function for a quintic (t^5) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuintEaseInOut(float t, float b, float c, float d)
        {
            if ((t /= d / 2) < 1)
                return c / 2 * t * t * t * t * t + b;
            return c / 2 * ((t -= 2) * t * t * t * t + 2) + b;
        }

        /// <summary>  
        /// Easing equation function for a quintic (t^5) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float QuintEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return QuintEaseOut(t * 2, b, c / 2, d);
            return QuintEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Elastic  

        /// <summary>  
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float ElasticEaseOut(float t, float b, float c, float d)
        {
            if ((t /= d) == 1)
                return b + c;

            float p = d * 0.3f;
            float s = p / 4;

            return (float)(c * Math.Pow(2, -10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p) + c + b);
        }

        /// <summary>  
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float ElasticEaseIn(float t, float b, float c, float d)
        {
            if ((t /= d) == 1)
                return b + c;

            float p = d * 0.3f;
            float s = p / 4;

            return (float)(-(c * Math.Pow(2, 10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p)) + b);
        }

        /// <summary>  
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float ElasticEaseInOut(float t, float b, float c, float d)
        {
            if ((t /= d / 2f) == 2)
                return b + c;

            float p = d * (0.3f * 1.5f);
            float s = p / 4;

            if (t < 1)
                return (float)(-0.5f * (c * Math.Pow(2, 10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p)) + b);
            return (float)(c * Math.Pow(2, -10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p) * 0.5f + c + b);
        }

        /// <summary>  
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float ElasticEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return ElasticEaseOut(t * 2, b, c / 2, d);
            return ElasticEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Bounce  

        /// <summary>  
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float BounceEaseOut(float t, float b, float c, float d)
        {
            if ((t /= d) < (1 / 2.75f))
                return c * (7.5625f * t * t) + b;
            else if (t < (2 / 2.75f))
                return c * (7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f) + b;
            else if (t < (2.5f / 2.75f))
                return c * (7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f) + b;
            else
                return c * (7.5625f * (t -= (2.625f / 2.75f)) * t + .984375f) + b;
        }

        /// <summary>  
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float BounceEaseIn(float t, float b, float c, float d)
        {
            return c - BounceEaseOut(d - t, 0, c, d) + b;
        }

        /// <summary>  
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float BounceEaseInOut(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return BounceEaseIn(t * 2, 0, c, d) * 0.5f + b;
            else
                return BounceEaseOut(t * 2 - d, 0, c, d) * 0.5f + c * 0.5f + b;
        }

        /// <summary>  
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float BounceEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return BounceEaseOut(t * 2, b, c / 2, d);
            return BounceEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Back  

        /// <summary>  
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float BackEaseOut(float t, float b, float c, float d)
        {
            return c * ((t = t / d - 1) * t * ((1.70158f + 1) * t + 1.70158f) + 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float BackEaseIn(float t, float b, float c, float d)
        {
            return c * (t /= d) * t * ((1.70158f + 1) * t - 1.70158f) + b;
        }

        /// <summary>  
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float BackEaseInOut(float t, float b, float c, float d)
        {
            float s = 1.70158f;
            if ((t /= d / 2) < 1)
                return c / 2 * (t * t * (((s *= (1.525f)) + 1) * t - s)) + b;
            return c / 2 * ((t -= 2) * t * (((s *= (1.525f)) + 1) * t + s) + 2) + b;
        }

        /// <summary>  
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float BackEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return BackEaseOut(t * 2, b, c / 2, d);
            return BackEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion
    }
}
