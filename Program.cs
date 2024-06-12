public class Solution
{
    public static List<int> FindSumPair(List<int> numbers, int k)
    {
        Dictionary<int, int> numberIndices = new Dictionary<int, int>();

        int value = 0;
        /*
        numbers ={1,5,8,1,2}
        */
        for(int i=0;i<numbers.Count;i++)
        {
            value = k - numbers[i];
            if(numberIndices.ContainsKey(value))
            {
                return new List<int> { numberIndices[value], i };
            }
            if(!numberIndices.ContainsKey(numbers[i]))
            {
                numberIndices[numbers[i]] = i;//1:0,5:1,8:2,1:3,2:4
            }
        }

        return new List<int>{ 0,0};
    }

    public static int ClosestToZero(int[] ints)
    {
        if(ints.Length == 0 || ints == null) return 0;
        int closest = ints[0];
        foreach (int num in ints)
        {
            if (Math.Abs(num) < Math.Abs(closest) ||
                (Math.Abs(num) == Math.Abs(closest) &&
                num > closest))
            {
                closest = num;
            }
        }
            return closest;
        
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return string.Empty;

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (string.IsNullOrEmpty(prefix)) return string.Empty;
            }
        }

        return prefix;
    }


    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 7, 5, 8, 1, 2 };
        List<int> numbers2 = new List<int>();
        numbers2 = FindSumPair(numbers, 13);

        Console.WriteLine(numbers2);

        int[] ints = { -9, 8, 2, -5, 7 };
        int results = ClosestToZero(ints);
        Console.WriteLine("Closest to Zero: "+results);


        string[] strs = { "flower", "flow", "flight" };
        Console.WriteLine($"Longest Common Prefix: {LongestCommonPrefix(strs)}"); // Output: "fl"

        strs = new string[] { "dog", "racecar", "car" };
        Console.WriteLine($"Longest Common Prefix: {LongestCommonPrefix(strs)}"); // Output: ""

        strs = new string[] { "interview", "interval", "integrate" };
        Console.WriteLine($"Longest Common Prefix: {LongestCommonPrefix(strs)}"); // Output: "int"


        Console.ReadLine();
    }
}