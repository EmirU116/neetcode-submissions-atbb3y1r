public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        // algorithm
        // Temp (streak counter)
        // Temp_Save (save the current highest streak)
        // look at each index of the list
        // if the index -> 1
            // increase count (temp)
        // if index is 0
            // (X) reset the counter (temp)
                // what happens if the max consecutive 1's comes first, resets and becomes lower?
                    // 1,1,1,0,1,1 -> this counts the 3 first, then resets and becomes 2
            // save the current score to Temp_Save and reset to 0 on the Temp
            // and keep iterating through the list to the end
        // make a comparison between current count and the saved
            // if saved temp is higher then current
                // dont do anything and return the value
            // else
                // reassign the value and return
        
        int con_Curr = 0;
        int con_Saved = 0;

        for(int i = 0; i < nums.Length; i++)
        {            
            if(nums[i] == 1)
            {
                con_Curr++;

            }
            else
            {
                con_Curr = 0;
            }
            
            if (con_Curr > con_Saved)
            {
                con_Saved = con_Curr;
            }
        }
        return con_Saved;

    }           
}