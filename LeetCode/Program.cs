
var nums1 = new int[] {1,2,3,0,0,0};
var nums2 = new int[] {2,5,6};
var m = 3;
var n = 3;

MergeSortedArray.Merge2(nums1, m, nums2, n);

nums1.ToList().ForEach(Console.WriteLine);

