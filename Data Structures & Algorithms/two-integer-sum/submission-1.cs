
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //target  = 9

        //val 2  7 11  15
        //key 0  1  2  3

        Dictionary<int, int> prevMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            // diff = 9 - 2 = > 7
            // diff = 9 - 7 = > 2
            if (prevMap.ContainsKey(diff)) {
                //false
                //true
                return new int[] {prevMap[diff], i};
                //prevMap[2] => 0  , 1
            }
            prevMap[nums[i]] = i;
            //prevMap[2] = 0;
        }
        return null;

    }
}