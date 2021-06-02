/*
 * @lc app=leetcode.cn id=300 lang=csharp
 *
 * [300] 最长递增子序列
 */


namespace Solutions {
    namespace IncreasingSubsequence300 {
        using System;
        using System.Collections.Generic;
        #if LOCAL
        using HelpFunctions;
        #endif
        // @lc code=start
        using System.Linq;

        public class Solution {

            int[] nums;
            int[] dps;
            int max;

            private int DPProcess(int x) {
                int y = Enumerable.Range(x + 1, nums.Length - 1 - x)
                        .Where(Index => nums[Index] > nums[x])
                        .Select(Index => dps[Index])
                        .DefaultIfEmpty(0)
                        .Max() + 1;
                if (y > max) { max = y; }
                return y;

            }
            public int LengthOfLIS(int[] nums) {
                if (nums.Length < 2) { return 1; }
                this.nums = nums;
                dps = new int[nums.Length];
                dps[^1] = max = 1;
                for (int x = nums.Length - 2; x >= 0; x -= 1) {
                    dps[x] = DPProcess(x);
                }

                return max;
            }
        }

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
        // @lc code=end

    }
}
