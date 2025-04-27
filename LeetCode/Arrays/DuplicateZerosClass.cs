public static class DuplicateZerosClass
{
    // 0.17*0.95=0.16
    public static void DuplicateZeros(int[] arr)
    {
        for (int i = arr.Length - 1 - 1; i >= 0; i--)
        {
            if (arr[i] == 0)
            {
                for (int j = arr.Length - 2; j >= i; j--)
                {
                    arr[j + 1] = arr[j];
                }
            }
        }
    }

    // 0.85*0.78=0.66
    public static void DuplicateZeros2(int[] arr)
    {
        var result = new int[arr.Length];
        
        for (int i = 0, j = 0; i < arr.Length - 1 && j < arr.Length; i++)
        {
            result[j++] = arr[i];
            
            if (arr[i] == 0)
            {
                result[j++] = 0;
            }
        }

        arr = result;
    }
}