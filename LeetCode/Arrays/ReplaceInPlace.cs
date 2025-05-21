public static class ReplaceInPlace
{
  // 0.14 * 0.00 = 0.00
  // 0.14 * 0.26 = 0.04
  // 0.09 * 0.37 = 0.03
  // 0.023
  public static int[] ReplaceElements(int[] arr)
  {

    var i = 0;

    while (i < arr.Length - 1)
    {
      var j = i + 1;
      var maxValue = int.MinValue;

      while (j < arr.Length)
      {
        if (arr[j] > maxValue)
        {
          maxValue = arr[j];
        }

        j++;
      }

      arr[i] = maxValue;
      i++;
    }

    arr[i] = -1;

    return arr;
  }

  // 0.67 * 0.26 = 0.17
  // 0.67 * 0.00 = 0.00
  // 0.67 * 0.5 = 0.33
  // 0.173
  public static int[] ReplaceElements2(int[] arr)
  {
    var i = 0;
    var maxValue = int.MinValue;
    var maxIndex = 0;

    while (i < arr.Length - 1)
    {
      if (i < maxIndex)
      {
        arr[i] = maxValue;
      }
      else
      {
        maxValue = int.MinValue;

        var j = i + 1;

        while (j < arr.Length)
        {
          if (arr[j] > maxValue)
          {
            maxValue = arr[j];
            maxIndex = j;
          }

          j++;
        }

        arr[i] = maxValue;
      }

      i++;
    }

    arr[i] = -1;

    return arr;
  }
}