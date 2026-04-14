public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> data = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
           if(!data.Add(nums[i])){
            return true;
           }
        }
        return false;
    }
}