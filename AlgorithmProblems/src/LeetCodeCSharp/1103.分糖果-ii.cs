/*
 * @lc app=leetcode.cn id=1103 lang=csharp
 *
 * [1103] 分糖果 II
 *
 * https://leetcode-cn.com/problems/distribute-candies-to-people/description/
 *
 * algorithms
 * Easy (63.44%)
 * Likes:    89
 * Dislikes: 0
 * Total Accepted:    33.7K
 * Total Submissions: 53.1K
 * Testcase Example:  '7\n4'
 *
 * 排排坐，分糖果。
 * 
 * 我们买了一些糖果 candies，打算把它们分给排好队的 n = num_people 个小朋友。
 * 
 * 给第一个小朋友 1 颗糖果，第二个小朋友 2 颗，依此类推，直到给最后一个小朋友 n 颗糖果。
 * 
 * 然后，我们再回到队伍的起点，给第一个小朋友 n + 1 颗糖果，第二个小朋友 n + 2 颗，依此类推，直到给最后一个小朋友 2 * n 颗糖果。
 * 
 * 
 * 重复上述过程（每次都比上一次多给出一颗糖果，当到达队伍终点后再次从队伍起点开始），直到我们分完所有的糖果。注意，就算我们手中的剩下糖果数不够（不比前一次发出的糖果多），这些糖果也会全部发给当前的小朋友。
 * 
 * 返回一个长度为 num_people、元素之和为 candies 的数组，以表示糖果的最终分发情况（即 ans[i] 表示第 i
 * 个小朋友分到的糖果数）。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 输入：candies = 7, num_people = 4
 * 输出：[1,2,3,1]
 * 解释：
 * 第一次，ans[0] += 1，数组变为 [1,0,0,0]。
 * 第二次，ans[1] += 2，数组变为 [1,2,0,0]。
 * 第三次，ans[2] += 3，数组变为 [1,2,3,0]。
 * 第四次，ans[3] += 1（因为此时只剩下 1 颗糖果），最终数组变为 [1,2,3,1]。
 * 
 * 
 * 示例 2：
 * 
 * 输入：candies = 10, num_people = 3
 * 输出：[5,2,3]
 * 解释：
 * 第一次，ans[0] += 1，数组变为 [1,0,0]。
 * 第二次，ans[1] += 2，数组变为 [1,2,0]。
 * 第三次，ans[2] += 3，数组变为 [1,2,3]。
 * 第四次，ans[0] += 4，最终数组变为 [5,2,3]。
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 1 <= candies <= 10^9
 * 1 <= num_people <= 1000
 * 
 * 
 */

namespace LeetCode.Q1103{

// @lc code=start
using System.Diagnostics;
using System;
    public class Solution {

        static int F(int r, int n) {
            return r*n*(r*n+1)/2; 
        }

        public int[] DistributeCandies(int candies, int n) {
            int intcandies = candies;
            var alloc = new int[n];
            int dummy;
            int left = 0, right = 45;

            int r;  
            while(true){
                r = (left + right)/2;
                bool A = F(r, n) < intcandies;
                switch (r){
                    case int _ when A:
                        left = r + 1; break;
                    
                    case int _ when !A && (dummy = F(r-1,n)) < intcandies:
                        intcandies -= dummy;
                        goto End;

                    case int _ :
                        right = r;
                        break;
                }
            } End:;
            
            // Console.WriteLine("firstLoop");
            r -= 1;
            
            int baseValue = r*(r-1)*n/2;
            for(int k = 0; k < n; k++ ){
                alloc[k] = baseValue + (k+1)*r;
            }
           //  Console.WriteLine("2ndLoop");
        

            
            int i = 0;
            int val = r*n + 1;
            while(true){
                if(intcandies <= val) {alloc[i] += (int)intcandies; break;}
                alloc[i] += val;
                intcandies -= val;
                i++; val++;
            }
            // Console.WriteLine("finalLoop");

            return alloc;
        }
    }
// @lc code=end
}

