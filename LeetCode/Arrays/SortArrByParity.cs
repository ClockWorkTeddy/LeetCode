public static class SortArrByParity
{
  // 1.0 * 0.28 = 0.28
  // 1.0 * 0.20 = 0.20
  // 1.0 * 0.52 = 0.52
  // 0.33
  public static int[] SortArrayByParity(int[] nums)
  {
    var reader = 0;
    var writer = 0;

    while (reader < nums.Length)
    {
      if (nums[reader] % 2 == 0)
      {
        var temp = nums[writer];
        nums[writer] = nums[reader];
        nums[reader] = temp;

        writer++;
      }

      reader++;
    }

    return nums;
  }

  // 1.0 * 0.40 = 0.40
  // 1.0 * 0.76 = 0.76
  // 1.0 * 0.96 = 0.96
  // 0.71

  public static int[] SortArrayByParity2(int[] nums)
  {
    var reader = 0;
    var writer = 0;
    var temp = 0;

    while (reader < nums.Length)
    {
      if (nums[reader] % 2 == 0)
      {
        temp = nums[writer];
        nums[writer] = nums[reader];
        nums[reader] = temp;

        writer++;
      }

      reader++;
    }

    return nums;
  }
}