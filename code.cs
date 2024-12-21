public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSubarraySum = int.MinValue, currSum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            currSum += nums[i]; // calculating the current sum
            maxSubarraySum = int.Max(currSum, maxSubarraySum); // maxSubarray sum calculation
            currSum = int.Max(0, currSum); // if the current sum is less than 0, then we dont need to add all those element in the sum as they will always just decrease the overall sum
        }

        return maxSubarraySum;
    }
}
