/*
 * @lc app=leetcode.cn id=209 lang=csharp
 *
 * [209] 长度最小的子数组
 *
 * https://leetcode-cn.com/problems/minimum-size-subarray-sum/description/
 *
 * algorithms
 * Medium (45.63%)
 * Likes:    628
 * Dislikes: 0
 * Total Accepted:    138.8K
 * Total Submissions: 303.2K
 * Testcase Example:  '7\n[2,3,1,2,4,3]'
 *
 * 给定一个含有 n 个正整数的数组和一个正整数 target 。
 * 
 * 找出该数组中满足其和 ≥ target 的长度最小的 连续子数组 [numsl, numsl+1, ..., numsr-1, numsr]
 * ，并返回其长度。如果不存在符合条件的子数组，返回 0 。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：target = 7, nums = [2,3,1,2,4,3]
 * 输出：2
 * 解释：子数组 [4,3] 是该条件下的长度最小的子数组。
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：target = 4, nums = [1,4,4]
 * 输出：1
 * 
 * 
 * 示例 3：
 * 
 * 
 * 输入：target = 11, nums = [1,1,1,1,1,1,1,1]
 * 输出：0
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 1 
 * 1 
 * 1 
 * 
 * 
 * 
 * 
 * 进阶：
 * 
 * 
 * 如果你已经实现 O(n) 时间复杂度的解法, 请尝试设计一个 O(n log(n)) 时间复杂度的解法。
 * 
 * 
 */

/*  🏆 
    Accepted
19/19 cases passed (100 ms)
Your runtime beats 100 % of csharp submissions
Your memory usage beats 38.1 % of csharp submissions (25.6 MB)
*/
namespace Solutions.Q209{

    // @lc code=start
    public class Solution{
        public int MinSubArrayLen(int target, int[] nums){

            int currentSum = nums[0], length = nums.Length;
            int left = 0, right = 0;
            int minLength = int.MaxValue;

            while (true){
                while (currentSum < target){
                    right++;
                    if (right >= length) { goto End; }
                    currentSum += nums[right];
                }

                {   int x;
                    if ((x = right - left + 1) < minLength) {minLength = x;}
                }

                if (left < right) { currentSum -= nums[left]; left++; }
                else{left = (right += 1);
                    if (right >= length) { break; }
                    currentSum = nums[left];
                    continue;
                }

            }
        End:
            if (minLength == int.MaxValue) return 0;
            return minLength;
        }
    }
    // @lc code=end
}

