public static class NAndDouble
{
    // 0.96 * 0.47 = 0.45
    public static bool CheckIfExist(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] * 2 == arr[i] && i != j)
                {
                    return true;
                }
            }
        }
        
        return false;
    }

    // 0.96 * 0.85 = 0.82
    public static bool CheckIfExist2(int[] arr)
    {
        int i = 0;
        
        while (i < arr.Length)
        {
            int j = 0;
            
            while (j < arr.Length)
            {
                if (arr[j] * 2 == arr[i] && i != j )
                {
                    return true;
                }
                
                j += 1;
            }
            
            i += 1;
        }
        
        return false;
    }
}