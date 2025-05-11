public static class RemoveDuplicatesFromSortedArray
{
    // 0.12 * 0.00 = 0.00
    public static int RemoveDuplicates(int[] nums)
    {
        // Create the hash
        var hash = new Dictionary<int, int>();
        
        // Iterate the array and fill the hash
        for (int i = 0; i < nums.Length; i++)
        {
            if (hash.ContainsKey(nums[i]))
            {
                continue;
            }
            hash[nums[i]] = 0;
        }
        
        var keys = hash.Keys.ToArray();

        // Copy keys from hash to the array
        for (int i = 0; i < keys.Length; i++)
        {
            nums[i] = keys[i];
        }
        
        return hash.Keys.Count;
    }

    // 0.16 * 0.00 = 0.00 
    public static int RemoveDuplicates2(int[] nums)
    {
         // Create the hash
        var hash = new Dictionary<int, int>();
        var maxNumber = nums[nums.Length - 1];
        var exit = false;
        
        // Iterate the array and fill the hash
        for (int i = 0; i < nums.Length && !exit; i++)
        {
            if (hash.ContainsKey(nums[i]))
            {
                continue;
            }
            hash[nums[i]] = 0;
            if (nums[i] == maxNumber)
            {
                exit = true;
            }
        }
        
        var keys = hash.Keys.ToArray();

        // Copy keys from hash to the array
        for (int i = 0; i < keys.Length; i++)
        {
            nums[i] = keys[i];
        }
        
        return hash.Keys.Count;
    }

    // 0.23 * 0.07 = 0.02
    public static int RemoveDuplicates3(int[] nums)
    {
         // Create the hash
        var distinct = new List<int>();
        var maxNumber = nums[nums.Length - 1];
        var exit = false;
        
        // Iterate the array and fill the hash
        for (int i = 0; i < nums.Length && !exit; i++)
        {
            if (distinct.Contains(nums[i]))
            {
                continue;
            }
            else
            {
                distinct.Add(nums[i]);
            }
            if (nums[i] == maxNumber)
            {
                exit = true;
            }
        }
        
        // Copy keys from hash to the array
        for (int i = 0; i < distinct.Count; i++)
        {
            nums[i] = distinct[i];
        }
        
        return distinct.Count;
    }

    // 1.00 * 0.33 = 0.33
    public static int RemoveDuplicates4(int[] nums)
    {
        var pointer = 1;
        var sortedPointer = 1;
        
        // Iterate the array
        while (pointer < nums.Length)
        {
            if (nums[pointer] != nums[pointer - 1])
            {
                nums[sortedPointer++] = nums[pointer];
            }
            
            pointer++;
        }
        
        return sortedPointer;
    }
}