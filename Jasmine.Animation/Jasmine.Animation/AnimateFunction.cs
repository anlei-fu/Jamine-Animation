using System;

namespace Jasmine.Animation
{
    public class AnimateFunction
    {
        /// <summary>
        /// use a special function to get value of float
        /// </summary>
        /// <param name="type"></param>
        /// <param name="time"> the rate of duration</param>
        /// <returns></returns>
        public static float Caculate(AnimateFunctionType type, float time)
        {
            switch (type)
            {
                case AnimateFunctionType.Linear:
                    return time;
                case AnimateFunctionType.BackEaseIn:
                    return backEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.BackEaseInOut:
                    return backEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.BackEaseOut:
                    return backEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.BackEaseOutIn:
                    return backEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.BounceEaseIn:
                    return bounceEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.BounceEaseInOut:
                    return bounceEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.BounceEaseOut:
                    return bounceEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.BounceEaseOutIn:
                    return bounceEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.CircEaseIn:
                    return circEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.CircEaseInOut:
                    return circEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.CircEaseOut:
                    return circEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.CircEaseOutIn:
                    return circEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.CubicEaseIn:
                    return cubicEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.CubicEaseInOut:
                    return cubicEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.CubicEaseOut:
                    return cubicEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.CubicEaseOutIn:
                    return cubicEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.ElasticEaseIn:
                    return elasticEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.ElasticEaseInOut:
                    return elasticEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.ElasticEaseOut:
                    return elasticEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.ElasticEaseOutIn:
                    return elasticEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.ExpoEaseIn:
                    return expoEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.ExpoEaseInOut:
                    return expoEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.ExpoEaseOut:
                    return expoEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.ExpoEaseOutIn:
                    return expoEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.QuadEaseIn:
                    return quadEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.QuadEaseInOut:
                    return quadEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.QuadEaseOut:
                    return quadEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.QuadEaseOutIn:
                    return quadEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.QuartEaseIn:
                    return quartEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.QuartEaseInOut:
                    return quartEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.QuartEaseOut:
                    return quartEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.QuartEaseOutIn:
                    return quartEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.QuintEaseIn:
                    return quintEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.QuintEaseInOut:
                    return quintEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.QuintEaseOut:
                    return quintEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.QuintEaseOutIn:
                    return quintEaseOutIn(time, 0, 1, 1);
                case AnimateFunctionType.SineEaseIn:
                    return sineEaseIn(time, 0, 1, 1);
                case AnimateFunctionType.SineEaseInOut:
                    return sineEaseInOut(time, 0, 1, 1);
                case AnimateFunctionType.SineEaseOut:
                    return sineEaseOut(time, 0, 1, 1);
                case AnimateFunctionType.SineEaseOutIn:
                    return sineEaseOutIn(time, 0, 1, 1);
                default:
                    return time;
            }

        }
        /// <summary>  
        /// Easing equation function for a simple linear tweening, with no easing.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float linear(float t, float b, float c, float d)
        {
            return c * t / d + b;
        }
        /// <summary>  
        /// Easing equation function for an exponential (2^t) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float expoEaseOut(float t, float b, float c, float d)
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
        private static float expoEaseIn(float t, float b, float c, float d)
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
        private static float expoEaseInOut(float t, float b, float c, float d)
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
        private static float expoEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return expoEaseOut(t * 2, b, c / 2, d);

            return expoEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }
        /// <summary>  
        /// Easing equation function for a circular (sqrt(1-t^2)) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float circEaseOut(float t, float b, float c, float d)
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
        private static float circEaseIn(float t, float b, float c, float d)
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
        private static float circEaseInOut(float t, float b, float c, float d)
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
        private static float circEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return circEaseOut(t * 2, b, c / 2, d);

            return circEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }
        /// <summary>  
        /// Easing equation function for a quadratic (t^2) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float quadEaseOut(float t, float b, float c, float d)
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
        private static float quadEaseIn(float t, float b, float c, float d)
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
        private static float quadEaseInOut(float t, float b, float c, float d)
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
        private static float quadEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return quadEaseOut(t * 2, b, c / 2, d);

            return quadEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }
        /// <summary>  
        /// Easing equation function for a sinusoidal (sin(t)) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float sineEaseOut(float t, float b, float c, float d)
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
        private static float sineEaseIn(float t, float b, float c, float d)
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
        private static float sineEaseInOut(float t, float b, float c, float d)
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
        private static float sineEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return sineEaseOut(t * 2, b, c / 2, d);

            return sineEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }
        /// <summary>  
        /// Easing equation function for a cubic (t^3) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float cubicEaseOut(float t, float b, float c, float d)
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
        private static float cubicEaseIn(float t, float b, float c, float d)
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
        private static float cubicEaseInOut(float t, float b, float c, float d)
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
        private static float cubicEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return cubicEaseOut(t * 2, b, c / 2, d);

            return cubicEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }
        /// <summary>  
        /// Easing equation function for a quartic (t^4) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float quartEaseOut(float t, float b, float c, float d)
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
        private static float quartEaseIn(float t, float b, float c, float d)
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
        private static float quartEaseInOut(float t, float b, float c, float d)
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
        private static float quartEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return quartEaseOut(t * 2, b, c / 2, d);

            return quartEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }
        /// <summary>  
        /// Easing equation function for a quintic (t^5) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float quintEaseOut(float t, float b, float c, float d)
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
        private static float quintEaseIn(float t, float b, float c, float d)
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
        private static float quintEaseInOut(float t, float b, float c, float d)
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
        private static float quintEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return quintEaseOut(t * 2, b, c / 2, d);
            return quintEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }
        /// <summary>  
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float elasticEaseOut(float t, float b, float c, float d)
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
        private static float elasticEaseIn(float t, float b, float c, float d)
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
        private static float elasticEaseInOut(float t, float b, float c, float d)
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
        private static float elasticEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return elasticEaseOut(t * 2, b, c / 2, d);
            return elasticEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }
        /// <summary>  
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float bounceEaseOut(float t, float b, float c, float d)
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
        private static float bounceEaseIn(float t, float b, float c, float d)
        {
            return c - bounceEaseOut(d - t, 0, c, d) + b;
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
        private static float bounceEaseInOut(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return bounceEaseIn(t * 2, 0, c, d) * 0.5f + b;
            else
                return bounceEaseOut(t * 2 - d, 0, c, d) * 0.5f + c * 0.5f + b;
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
        private static float bounceEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return bounceEaseOut(t * 2, b, c / 2, d);
            return bounceEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }
        /// <summary>  
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        private static float backEaseOut(float t, float b, float c, float d)
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
        private static float backEaseIn(float t, float b, float c, float d)
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
        private static float backEaseInOut(float t, float b, float c, float d)
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
        private static float backEaseOutIn(float t, float b, float c, float d)
        {
            if (t < d / 2)
                return backEaseOut(t * 2, b, c / 2, d);
            return backEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }
    }
}
