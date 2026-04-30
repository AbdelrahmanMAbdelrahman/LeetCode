using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        string message = "my name is abdelrahamn";
        var code = Encoding.UTF8.GetBytes(message);
       string Encode = Convert.ToBase64String(code);
        Console.WriteLine( Encode);
        var decode = Convert.FromBase64String(Encode);
        string newMessage=Encoding.UTF8.GetString(decode);
        Console.WriteLine( newMessage);

        //Console.WriteLine(Day1.Reverse(123));
    } }
    //public static string LongestCommonPrefix(string[] strs)
    //{
    //    string pref = "";
    //    List<string> words = strs.ToList();
    //    foreach (char ch in strs[0])
    //    {
    //        foreach (var word in words)
    //        {
    //            if (!word.StartsWith(pref + ch))
    //            {
    //                return pref;
    //            }
    //        }
    //        pref += ch;
    //        if (words.Count() == 1) return pref;
    //    }
    //    return pref;
    //}

    //public static int RomanToInt(string s)
    //{
    //    //Dictionary<char, int> romans = new Dictionary<char, int>()
    //    //{
    //    //    {'I',1 },
    //    //    {'V',5 },
    //    //    {'X',10 },
    //    //    {'L',50 },
    //    //    {'C',100 },
    //    //    {'D',500 },
    //    //    {'M',1000 },
    //    //};
    //    int result = 0;
    //    int curVal = 0;
    //    int nextVal = 0;
    //    for (int i = 0; i < s.Length; i++)
    //    {

    //        if (i < s.Length - 1)
    //        {
    //            curVal = GetValue(s[i]);
    //            nextVal = GetValue(s[i + 1]);
    //            if (curVal >= nextVal)
    //            {
    //                result += curVal;
    //            }
    //            else {
    //                result -= curVal;
    //            }
    //        }
    //    }
    //        result += GetValue(s[s.Length-1]);
    //    return result;
    //}
    //public static int GetValue(char c)
    //{
    //    return c switch {
    //        'I'=>1 ,
    //    'V'=>5 ,
    //    'X'=>10 ,
    //     'L'=>50,
    //    'C'=>100,
    //    'D'=>500,
    //    'M'=>1000,
    //    _=>0
    //    };

    //}
    //public static int RemoveDuplicates(int[] nums)
    //{
    //    int counter = 0;

    //    for(int i = 1; i < nums.Length; i++)
    //    {
    //        if (nums[counter] != nums[i])
    //        {
    //            counter++;
    //            nums[counter] = nums[i];
    //        }

    //    }

    //    return counter+1 ;
    //}
    //public static bool IsValid(string s)
    //{
    //    Stack<char>chars = new Stack<char>();
    //    foreach (char c in s) { 
    //        switch (c) { 
    //        case '(':
    //                chars.Push(')');

    //                break;
    //        case '{':
    //                chars.Push('}');
    //                break;
    //        case '[':
    //                chars.Push(']');
    //                break;

    //        default :
    //                if ( chars.Count == 0||c != chars.Pop() ) return false;
    //                break;
    //        }
    //    }
    //        return chars.Count == 0;    


    //}
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("=== Optimal Session Scheduler ===");

    //        // 1. Input: Number of sessions
    //        Console.Write("Enter the total number of sessions: ");
    //        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
    //        {
    //            Console.WriteLine("Invalid input. Please enter a positive integer.");
    //            return;
    //        }

    //        List<Session> sessions = new List<Session>();

    //        // 2. Input: Session details
    //        Console.WriteLine("\nEnter start and end times (e.g., '10 12') for each:");
    //        for (int i = 0; i < n; i++)
    //        {
    //            try
    //            {
    //                Console.Write($"Session {i + 1}: ");
    //                string[] parts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    //                string? customer = Console.ReadLine();
    //                int start = int.Parse(parts[0]);
    //                int end = int.Parse(parts[1]);

    //                sessions.Add(new Session
    //                {
    //                    Start = start,
    //                    End = end,
    //                    customer =customer  // Human-friendly 1-based indexing
    //                });
    //            }
    //            catch
    //            {
    //                Console.WriteLine("Invalid format. Please enter two numbers separated by a space.");
    //                i--; // Retry current index
    //            }
    //        }

    //        // 3. The Greedy Strategy: Sort by end time
    //        // This ensures we finish a session as early as possible to fit others.
    //        var sortedSessions = sessions
    //            .OrderBy(s => s.End)
    //            .ThenBy(s => s.Start)
    //            .ToList();

    //        List<string> chosenIndices = new List<string>();
    //        int lastEndTime = int.MinValue;

    //        // 4. Activity Selection Logic
    //        foreach (var s in sortedSessions)
    //        {
    //            // Condition: Current session must start at or after the previous one ends
    //            if (s.Start >= lastEndTime)
    //            {
    //                chosenIndices.Add(s.customer);
    //                lastEndTime = s.End;
    //            }
    //        }

    //        // 5. Output Results
    //        Console.WriteLine("\n" + new string('=', 35));
    //        Console.WriteLine("SCHEDULING RESULTS");
    //        Console.WriteLine(new string('=', 35));
    //        Console.WriteLine($"Max non-overlapping sessions: {chosenIndices.Count}");
    //        Console.WriteLine($"Selected Session IDs: {string.Join(", ", chosenIndices)}");
    //        Console.WriteLine(new string('=', 35));

    //        Console.WriteLine("\nPress any key to exit...");
    //        Console.ReadKey();


    //}
    //public static int[] TwoSum(int[] nums, int target)
    //{
    //    List<int>indices=new List<int>();
    //    for (int j= 0; j < nums.Count();j++) {
    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            if (nums[j] + nums[i] == target&&i!=j && !indices.Contains(j))
    //            {
    //                indices.AddRange([j,i]);
    //            }
    //        }
    //    }
    //    return indices.ToArray();
    //}

    //public static int RemoveElement(int[] nums, int val)
    //{
    //    int counter = 0;
    //    for (int i = 0; i < nums.Count(); i++)
    //    {
    //        if (nums[i] != val)
    //        {
    //            nums[counter]=nums[i];
    //            counter++;
    //        }
    //    }

    //        return counter;
    //}
    //public static string AddBinary(string a, string b)
    //{
    //    makeEqual( ref a,ref  b);
    //    return sum(a,b);
    //}
    //public static string sum(string a,string b)

    //{
    //    bool reminder = false;
    //    Stack<string> sum = new Stack<string>();
    //    int sumOf = 0;
    //    for (int i = a.Length - 1; i >= 0; i--)
    //    {
    //        sumOf =Convert.ToInt32 ( a[i].ToString()) + Convert.ToInt32(b[i].ToString()) ;
    //        sumOf += reminder  ? 1 : 0;
    //        if (sumOf < 2) {
    //            sum.Push( $"{sumOf}");
    //        reminder = false; }
    //        else { 
    //            sum.Push ( $"{(sumOf-2)}");
    //            reminder = true;

    //        }
    //    }
    //    if (reminder) sum.Push("1");


    //    return string.Join("",sum);
    //    } 
    //public static void makeEqual(ref string a,ref string b)
    //{
    //    int aLen = a.Length;
    //    int bLen = b.Length;

    //    if (aLen > bLen)
    //    {
    //        StringBuilder temp = new StringBuilder();
    //        for (int i = 0; i < aLen - bLen; i++)
    //        {
    //            temp.Append( "0");
    //        }
    //        temp.Append(b);
    //        b= temp.ToString();
    //    }
    //    else if (aLen < bLen)
    //    {
    //        StringBuilder temp = new StringBuilder();
    //        for (int i = 0; i < bLen - aLen; i++)
    //        {
    //            temp.Append("0");
    //        }
    //        temp.Append(a);
    //        a= temp.ToString();
    //    }
    //}
    //public int LengthOfLastWord(string s)
    //{
    //    s.TrimEnd();
    //    StringBuilder sb = new StringBuilder();
    //    for (int i = s.Length; i > 0; i++)
    //    {if (s[i] == ' ') return sb.Length;
    //        sb.Append(s[i]);
    //    }
    //    return sb.Length;
    //}
    //public static int[] PlusOne(int[] digits)
    //{
    //    int length = digits.Length;

    //    for(int i = length - 1; i >= 0; i--)
    //    {
    //        if (digits[i] <9)
    //        {
    //            digits[length - 1]++;
    //            return digits;
    //        }
    //        digits[i] = 0;
    //    }
    //    int[] result = new int[length + 1];
    //    result[0] = 1;
    //    return result;

    //int Newlength= string.Join("", digits).Length;
    //if (Newlength > length) {
    //    int[] temp = digits;
    //    digits = new int[Newlength];
    //    for (int i = length - 1; i >= 0; i--)
    //    {
    //        digits[i] = temp[i];
    //    }
    //}

    //for (int i = Newlength - 1; i >= 0; i--)
    //{
    //    if (digits[i] == 0)
    //    {
    //        //digits[i] = digits[i] + 1;
    //        //digits[length - 1] = digits[length - 1] + 1;
    //        digits[i] = digits[i] % 10;
    //        digits[i - 1] = digits[i] / 10;
    //    }
    //    break;
    //}

    //public static int MySqrt(int x)
    //{
    //    x = Math.Abs(x);
    //    if (x < 4 && x > 0) return 1;
    //    if (x > 4 && x < 9) return 2;
    //    if (x == 2147483647) return 46340;

    //    for (int i = 1; i <= x / 2; i++)
    //    {
    //        if (i * i == x) return i;
    //        else if (i * i > x) return i - 1;
    //    }
    //    return 0;
    //}
    //public static List<int> getHighest(int input, List<int> scores, int k)
    //{
    //    List<int> highest = new List<int>();
    //    if (k > input) return new List<int>();
    //    int max = 0;
    //    for (int i = 0; i < 3; i++)
    //    {
    //        max = scores.Max();
    //        highest.Add(max);
    //        scores.Remove(max);
    //    }
    //    highest.OrderDescending();
    //    return highest;
    //}
    //public static  int StrStr(string haystack, string needle)
    //{
    //    if (haystack.StartsWith(needle)) return 0;
    //   // if (haystack.Contains(needle))
    //   // {
    //        string split = "";
    //        for (int i = 0; i < haystack.Length; i++)
    //        {
    //            split=haystack.Substring(i, haystack.Length - i);
    //            if(split.StartsWith( needle)) return i;
    //        }
    //   // }
    //    return -1;
    //}

