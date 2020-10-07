using System;
using System.Collections.Generic;

/*
 * https://leetcode.com/problems/two-sum/
 * 
 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 * You can return the answer in any order.
 */
public class _TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        var compare = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; ++i)
        {
            if (compare.ContainsKey(nums[i]))
            {
                result[0] = i;
                result[1] = compare[nums[i]];
                return result;
            }

            var inverted = target - nums[i];
            if (!compare.ContainsKey(inverted))
            {
                compare.Add(inverted, i);
            }
        }

        return result;
    }
}

