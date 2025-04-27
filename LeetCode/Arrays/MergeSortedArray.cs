public static class MergeSortedArray
{
    // 0.12*0.11=0.01
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = m, j = 0; i < n + m && j < n; i++, j++)
        {
            nums1[i] = nums2[j];
        }
        
        Array.Sort(nums1);
    }

    // 1.00*0.98=0.98
    public static void Merge2(int[] nums1, int m, int[] nums2, int n)
    {
        int[] result = new int[n + m];
        
        int i = 0;
        int j = 0;
        int k = 0;
        
        if (m == 0 && n == 0)
        {
            return;
        }
        else if (m == 0)
        {
            for (int p = 0; p < n; p++)
            {
                nums1[p] = nums2[p];
            }
            
            return;
        }
        else if (n == 0)
        {
            return;
        }
        else
        {
            while (k < m + n)
            {
                if (j < n && (nums2[j] <= nums1[i] || i >= m))
                {
                    result[k++] = nums2[j++];
                }
                else
                {
                    result[k++] = nums1[i++];
                }
            }
            
            for (int p = 0; p < m + n; p++)
            {
                nums1[p] = result[p];
            }
        }
    }
}