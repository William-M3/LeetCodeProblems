// First Answer in O(n^2)

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++){
                if((nums[i]+nums[j]) == target){
                    return [i,j];
                }
            }
        }
        return [0,0];
    }
}

// Second Answer is O(n)
// Uses a 1-way hash table to solve the problem
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if(map.ContainsKey(complement) && map[complement] != i)
            {
                return [i, map[complement]];
            }
            else
            {
                map[nums[i]] = i ;     
            }
        }
        return [0,0];
    }
}