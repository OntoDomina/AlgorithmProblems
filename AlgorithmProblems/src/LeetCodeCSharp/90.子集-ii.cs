/*
 * @lc app=leetcode.cn id=90 lang=csharp
 *
 * [90] 子集 II
 *
 * https://leetcode-cn.com/problems/subsets-ii/description/
 *
 * algorithms
 * Medium (63.32%)
 * Likes:    583
 * Dislikes: 0
 * Total Accepted:    113.2K
 * Total Submissions: 178.6K
 * Testcase Example:  '[1,2,2]'
 *
 * 给你一个整数数组 nums ，其中可能包含重复元素，请你返回该数组所有可能的子集（幂集）。
 * 
 * 解集 不能 包含重复的子集。返回的解集中，子集可以按 任意顺序 排列。
 * 
 * 
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：nums = [1,2,2]
 * 输出：[[],[1],[1,2],[1,2,2],[2],[2,2]]
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
 * 
 * 
 * 
 * 
 */


namespace Solutions.Subset90{    

    using HelpFunctions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
// @lc code=start
    #if LOCAL != true
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

        public IList<IList<int>> SubsetsWithDup(int[] nums) {
            n = (UInt16)nums.Length;
            nover2 = Math.Pow(2,n).ApplyMeTo(x => Math.Round(x + 0.5))
                        .ApplyMeTo(Convert.ToInt32);
            mynums = nums;
            var intslist = new List<IList<int>>(nover2) ;
            Console.WriteLine(nover2);
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
