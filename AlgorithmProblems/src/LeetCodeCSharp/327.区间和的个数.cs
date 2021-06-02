/*
 * @lc app=leetcode.cn id=327 lang=csharp
 *
 * [327] 区间和的个数
 *
 * https://leetcode-cn.com/problems/count-of-range-sum/description/
 *
 * algorithms
 * Hard (43.11%)
 * Likes:    325
 * Dislikes: 0
 * Total Accepted:    22.1K
 * Total Submissions: 51.5K
 * Testcase Example:  '[-2,5,-1]\n-2\n2'
 *
 * 给你一个整数数组 nums 以及两个整数 lower 和 upper 。求数组中，值位于范围 [lower, upper] （包含 lower 和
 * upper）之内的 区间和的个数 。
 * 
 * 区间和 S(i, j) 表示在 nums 中，位置从 i 到 j 的元素之和，包含 i 和 j (i ≤ j)。
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：nums = [-2,5,-1], lower = -2, upper = 2
 * 输出：3
 * 解释：存在三个区间：[0,0]、[2,2] 和 [0,2] ，对应的区间和分别是：-2 、-1 、2 。
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：nums = [0], lower = 0, upper = 0
 * 输出：1
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 1 
 * -2^31 
 * -3 * 10^4 
 * 
 * 
 * 
 * 
 * 提示：最直观的算法复杂度是 O(n^2) ，请在此基础上优化你的算法。
 * 
 */

// @lc code=start
/* 
public class Solution {
    public int CountRangeSum(int[] nums, int lower, int upper) {

    }
} */
// @lc code=end 




