public static class MoveZeros
{
  // 0.95 * 0.20 = 0.19
  // 0.96 * 0.81 = 0.78
  // 0.96 * 0.59 = 0.56
  // 0.51
  public static void MoveZeroes(int[] nums)
  {
    var zeroCounter = 0;
    var index = 0;

    while (index < nums.Length)
    {
      if (nums[index] == 0)
      {
        zeroCounter++;
      }
      else if (zeroCounter > 0)
      {
        nums[index - zeroCounter] = nums[index];
      }

      index++;
    }

    while (zeroCounter > 0)
    {
      nums[nums.Length - zeroCounter] = 0;
      zeroCounter--;
    }
  }
}