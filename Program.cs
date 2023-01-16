int[] arrayNums = new int[] { 2, 7, 11, 15 };
int resultSearch = 9;

Console.WriteLine("Entrie values: ");
Console.Write("[");
foreach (var item in arrayNums)
{
  Console.Write("{0}", item);
  if(item != arrayNums[arrayNums.Length-1]) Console.Write(", ");
}
Console.WriteLine("]");

Console.WriteLine("Values search: {0}", resultSearch);

Console.WriteLine("Algorithm 1 apply:");
int[] result = TwoSum(arrayNums, resultSearch);
if (result[0] == -1)
  Console.WriteLine("Not Found");
else
  Console.WriteLine("{0} - {1}", result[0], result[1]);

Console.WriteLine("Algorithm 2 apply:");
result = TwoSum2(arrayNums, resultSearch);
if (result[0] == -1)
  Console.WriteLine("Not Found");
else
  Console.WriteLine("{0} - {1}", result[0], result[1]);

// Algorithm 1
int[] TwoSum(int[] nums, int target)
{
  int[] result = new int[] { -1, -1 };

  int pos1 = 0;
  int pos2 = 1;

  while (pos1 < nums.Length)
  {
    pos2 = pos1 + 1;
    while (pos2 < nums.Length)
    {
      if (nums[pos1] + nums[pos2] == target)
      {
        result = new int[] { pos1, pos2 };
        return result;
      }
      pos2++;
    }
    pos1++;
  }

  return result;
}

// Algorithm 2
int[] TwoSum2(int[] nums, int target)
{
  int[] result = new int[] { -1, -1 };

  int pos = 0;
  int valueSearch = 0;

  while (pos < nums.Length)
  {
    valueSearch = target - nums[pos];
    for (int i = pos+1; i < nums.Length; i++)
    {
      if(valueSearch == nums[i]) {
        result = new int[] {pos, i};
        return result;
      }
    }
    pos++;
  }

  return result;
}