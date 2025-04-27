public static class RemoveElementClass
{
    // 1.00*0.98=0.98
    public static int RemoveElement(int[] nums, int val)
    {
        int[] result = new int[nums.Length];
        int counter = 0;
        int j = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                result[j++] = nums[i];
                counter++;
            }
        }
        
        for (int i = 0; i < counter; i++)
        {
            nums[i] = result[i];
        }
        
        return counter;
    }
} 