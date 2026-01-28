namespace core
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string? s = Console.ReadLine();
           // Console.WriteLine(Solution.LengthOfLongestSubstring(s));
            Solution.LengthOfLongestSubstring(s);
        }
    }



    public static class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            //abccababc
            if (s == "")
            {
                return 0;
            }
            s.ToArray();
           
            int mayor = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char[] test = new char[1];
                
                test[0] = s[i];
                
                for(int j = i+1; j<s.Length; j++)
                {
                    if (!test.Contains(s[j]))
                    {
                        Array.Resize(ref test, test.Length+1);
                        test[test.Length-1] = s[j];

                    } else
                    {
                        break;
                    }
                    
                    if(test.Length> mayor)
                    {
                        mayor = test.Length;
                    }

                  
                }           
            }
            if (mayor == 0)
            {
                mayor = 1;
            }
            return mayor;
        }


        /*public static int SegundoIntento(string s)
        {
            char[] arr = s.ToCharArray();
            int mayor = 0;
            char[] test = new char[arr.Length];
            for (int i = 0; i< arr.Length; i++)
            {
                Array.Clear(test,0,test.Length);
                test[0] = arr[i];
                for (int j = i+1; j<arr.Length; j++)
                {
                    if (!test.Contains(arr[j]))
                    {
                        test[j]=arr[j];
                    }
                    else
                    {
                        break;
                    }
                    int m = 0;
                    foreach (char c in test)
                    {
                        
                        if (c != '\0')
                        {
                            m += 1;
                        }
                    }
                    if (m > mayor)
                    {
                        mayor = m;
                    }

                    
                }
            }




            return mayor;
        }
 */ }


}