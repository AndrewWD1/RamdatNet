using System;

namespace RamdatNet
{
    public partial class R
    {
        /// <summary>
        /// Returns a function that when supplied an object returns the indicated property of that object, if it exists.
        /// </summary>
        /// <code>
        /// R.Prop("x")(new { x = 100 }); //=> 100
        /// </code>
        public static Func<object, object> Prop(string propName)
            => obj =>
            {
                var Prop = obj.GetType()
                           .GetProperty(propName);

                if (Prop == null) return null;

                var t = Prop.GetValue(obj);

                return t;
            };

        /// <summary>
        /// Returns a function that when supplied an object returns the indicated property of that object, if it exists.
        /// </summary>
        /// <code>
        /// R.Prop{int}("x")(new { x = 100 }); //=> 100
        /// </code>
        public static Func<object, T> Prop<T>(string propName)
            => obj =>
            {
                var Prop = obj.GetType()
                           .GetProperty(propName);

                if (Prop == null) return default;

                T t = (T)Prop.GetValue(obj);

                return t;
            };
    }
}