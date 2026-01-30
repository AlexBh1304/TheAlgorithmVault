namespace core
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[]a = {1,2,3,4,5};
            Console.WriteLine(hasDuplicate3(a));   
        }





        public static bool hasDuplicate1(int[]nums)
        {
            bool x = false;
            for (int i = 0; i< nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j])
                    {
                        x = true;
                        return x;
                    }
                }
            }
            return x;
        }

        public static bool hasDuplicate2(int[] nums)
        {
            bool x = false;
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if(nums [i-1] == nums[i])
                {
                    x = true;
                    return x;
                }
            }
            return x;
        }

        public static bool hasDuplicate3(int[] nums)
        {
            bool x = false;
            HashSet<int> hNums = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hNums.Contains(nums[i]))
                {
                    return true;
                }
                hNums.Add(nums[i]);
                
            }




            return x;
        }
    }
}