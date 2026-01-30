namespace core
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string s = "jam";
            string t = "maj";
            Console.WriteLine(Solution.isAnagram(s,t));
        }
    }





    public static class Solution
    {
        public static bool isAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }

            char[] sSorted = s.ToCharArray();
            char[] tSorted = t.ToCharArray();

            Array.Sort(sSorted);
            Array.Sort(tSorted);

            return sSorted.SequenceEqual(tSorted);
        }
        




















        /*
        public static bool isAnagram(string s, string t)
        {
            
            bool x = true;
            HashSet<char> chars = new HashSet<char>(s);
            HashSet<char> charx = chars;
            HashSet<char> chars1 = new HashSet<char>(t);
            if (chars.Count != chars1.Count)
            {
                x = false;
                return x;
            }
            chars.InersectWith(chars1);
           
            if(chars.Count == charx.Count)
            {
                x = false;
                return x;
            }


            return x; 
        }
        // Esta solución no funciona, ya que en HashSets se ignoran los duplicados, pero en los anagramas si importan.
        */


    }
}