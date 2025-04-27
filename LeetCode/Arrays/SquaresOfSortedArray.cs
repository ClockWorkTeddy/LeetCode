public static class SquaresOfSortedArray
{
    // 0.33*0.12=0.04
  public static int[] SortedSquares(int[] nums)
  { 
    var squaredInput = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
      squaredInput[i] = nums[i] * nums[i];
    }

    Array.Sort(squaredInput);

    return squaredInput;
  }

  // 0.22*0.83=0.18
  public static int[] SortedSquares2(int[] nums)
  { 
    var squaredInput = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
      squaredInput[i] = (int)Math.Pow(nums[i], 2);
    }

    Array.Sort(squaredInput);

    return squaredInput;
  }

  // 0.22*0.93=0.20
  public static int[] SortedSquares3(int[] nums)
  { 
    for (int i = 0; i < nums.Length; i++)
    {
      nums[i] = (int)Math.Pow(nums[i], 2);
    }

    Array.Sort(nums);

    return nums;
  }

  // 0.42*0.73 = 0.31
  public static int[] SortedSquares4(int[] nums)
  { 
    for (int i = 0; i < nums.Length; i++)
    {
      nums[i] = nums[i] * nums[i];
    }

    Array.Sort(nums);

    return nums;
  }
}