namespace HelpFunctions{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;

    public static class HelpFunctions{
        public static T CastTo<T>(this object obj){
            return (T)obj;
        }

        public static TResult ApplyMeTo<TMe,TResult>(this TMe obj, Func<TMe, TResult> fn){
            return fn(obj);
        }

        public static void ForEach<TSource>(this IEnumerable<TSource> list, Action<TSource> fn){
            foreach (var x in list) {
                fn(x);
            }
        }

        public static void MyAssert(bool v, string str = ""){
            if(!v) {throw new Exception(str);}
        }

        [Conditional("LOCAL")]
        public static void MYWriteLine(string str){
            Console.WriteLine(str);
        }

            
    }

}