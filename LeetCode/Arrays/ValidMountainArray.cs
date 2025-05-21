public static class ValidMountainArrayClass
{
  //0.42 * 0.58 = 0.24
  public static bool ValidMountainArray(int[] arr)
  {
      var top = false;
              
      if (arr.Length < 3)
      {
          return false;
      }
      
      int i = 1;
      
      while (i < arr.Length)
      {
          if (!top)
          {
              if (arr[i] == arr[i - 1])
              {
                  return false;
              }
              else if (arr[i] < arr[i - 1])
              {
                  if (i == 1)
                  {
                      return false;
                  }
                  
                  top = true;
              }
              else if (i == arr.Length - 1)
              {
                  return false;
              }
          }
          else
          {
              if (arr[i] >= arr[i - 1])
              {
                  return false;
              }
          }
          
          i++;
      }
      
      return true;
  }

  // 0.95*0.40 = 0.38
  public static bool ValidMountainArray2(int[] arr)
    {
      var top = false;
              
      if (arr.Length < 3)
      {
          return false;
      }
      
      int i = 1;
      
      while (i < arr.Length)
      {
          if (!top)
          {
              if (arr[i] > arr[i - 1])
              {
                  if (i == arr.Length - 1)
                  {
                      return false;
                  }
              }
              else if (arr[i] < arr[i - 1])
              {
                  if (i == 1)
                  {
                      return false;
                  }
                  
                  top = true;
              }
              else
              {
                  return false;
              }
          }
          else
          {
              if (arr[i] < arr[i - 1])
              {
                  ;
              }
              else
              {
                  return false;
              }
          }
          
          i++;
      }
      
      return true;
    }
}