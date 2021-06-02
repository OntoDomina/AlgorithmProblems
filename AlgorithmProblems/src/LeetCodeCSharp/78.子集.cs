/*
 * @lc app=leetcode.cn id=78 lang=csharp
 *
 * [78] 子集
 *
 * https://leetcode-cn.com/problems/subsets/description/
 *
 * algorithms
 * Medium (79.81%)
 * Likes:    1200
 * Dislikes: 0
 * Total Accepted:    252.9K
 * Total Submissions: 316.8K
 * Testcase Example:  '[1,2,3]'
 *
 * 给你一个整数数组 nums ，数组中的元素 互不相同 。返回该数组所有可能的子集（幂集）。
 * 
 * 解集 不能 包含重复的子集。你可以按 任意顺序 返回解集。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：nums = [1,2,3]
 * 输出：[[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：nums = [0]
 * 输出：[[],[0]]
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 1 
 * -10 
 * nums 中的所有元素 互不相同
 * 
 * 
 */


namespace Solutions.Subset78{    
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
        int[] mynums;
        int nover2;
        UInt16 n;

        public IEnumerable<int> CorList(ushort X, ushort N){
            UInt16 mask = 1;
        
            for(UInt16 i = 0 ; i < N; i++){
                if( (mask & X) > 0) {yield return this.mynums[i];}
                mask <<= 1;
            }
        }

            
            public IList<IList<int>> Subsets(int[] nums) {
            n = (UInt16)nums.Length ;
            nover2 = Math.Pow(2,n).ApplyMeTo(x => Math.Round(x + 0.5))
                        .ApplyMeTo(Convert.ToInt32);
            mynums = nums;
            var intslist = new List<IList<int>>(nover2) ;
            Enumerable.Range(0,nover2).ForEach(x => 
                    {var z =  CorList((ushort)x, n);
                    Console.WriteLine(x);
                     intslist.Add(new List<int>(z)) ; 
                    } );
            return intslist;
            
            }
        }
        

// @lc code=end

   }



