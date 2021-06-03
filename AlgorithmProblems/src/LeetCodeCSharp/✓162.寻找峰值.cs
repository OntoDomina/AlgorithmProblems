/*
 * @lc app=leetcode.cn id=162 lang=csharp
 *
 * [162] 寻找峰值
 *
 * https://leetcode-cn.com/problems/find-peak-element/description/
 *
 * algorithms
 * Medium (48.75%)
 * Likes:    437
 * Dislikes: 0
 * Total Accepted:    95.7K
 * Total Submissions: 195.4K
 * Testcase Example:  '[1,2,3,1]'
 *
 * 峰值元素是指其值大于左右相邻值的元素。
 * 
 * 给你一个输入数组 nums，找到峰值元素并返回其索引。数组可能包含多个峰值，在这种情况下，返回 任何一个峰值 所在位置即可。
 * 
 * 你可以假设 nums[-1] = nums[n] = -∞ 。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：nums = [1,2,3,1]
 * 输出：2
 * 解释：3 是峰值元素，你的函数应该返回其索引 2。
 * 
 * 示例 2：
 * 
 * 
 * 输入：nums = [1,2,1,3,5,6,4]
 * 输出：1 或 5 
 * 解释：你的函数可以返回索引 1，其峰值元素为 2；
 * 或者返回索引 5， 其峰值元素为 6。
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 1 
 * -2^31 
 * 对于所有有效的 i 都有 nums[i] != nums[i + 1]
 * 
 * 
 * 
 * 
 * 进阶：你可以实现时间复杂度为 O(logN) 的解决方案吗？
 * 
 */

 /* 💡 A better Way would be to use splitting with the 
  rate of 0.618, the corresponding complexity would be O(㏒(n))
  */
  
namespace Solutions.LeetCode162{
    
    // @lc code=start
    public class Solution {
        public int FindPeakElement(int[] nums) {
            // bool isIncreasing = true;
            int current = nums[0];
            int next;
            int i = 1, length = nums.Length;
            while(i<length){
                next = nums[i];
                if(next<current){return i-1;}
                current = next;
                i++;
            }
            return length-1;
        }
    }
    // @lc code=end

}
