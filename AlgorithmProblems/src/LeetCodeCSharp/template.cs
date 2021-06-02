
namespace Solutions.Template{    


    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Solutions.HelpFunctions;
// @lc code=start
        #region Helpfunctions
        #if LOCAL == false
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
        }
        #endif
        #endregion 

    public class Solution {
       
    }
        

// @lc code=end

   }
