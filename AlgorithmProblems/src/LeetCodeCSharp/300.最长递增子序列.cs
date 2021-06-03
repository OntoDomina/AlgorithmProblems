/*
 * @lc app=leetcode.cn id=300 lang=csharp
 *
 * [300] 最长递增子序列
 */


namespace Solutions
{
    namespace IncreasingSubsequence300
    {
        using System;
        using System.Collections.Generic;
        using HelpFunctions;
        // @lc code=start
        using System.Linq;

        public class Solution
        {

            int[] nums;
            int[] dps;
            int maxLength;



            private int GetLongestAfter(int i)
            {
                int maxLength = 0;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] <= nums[i]) { continue; }
                    {
                        int x;
                        if ((x = dps[j]) > maxLength) { maxLength = x; }
                    }
                }

                return maxLength;
            }

            private int DPProcess(int x)
            {
                int y = GetLongestAfter(x) + 1;
                if (y > maxLength) { maxLength = y; }
                return y;

            }
            public int LengthOfLIS(int[] nums)
            {
                if (nums.Length < 2) { return 1; }
                this.nums = nums;
                dps = new int[nums.Length];
                dps[^1] = maxLength = 1;
                for (int x = nums.Length - 2; x >= 0; x -= 1)
                {
                    dps[x] = DPProcess(x);
                }

                return maxLength;
            }
        }
        /* #region HelpFunctions
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
        #endregion*/

        // @lc code=end

    }
}
