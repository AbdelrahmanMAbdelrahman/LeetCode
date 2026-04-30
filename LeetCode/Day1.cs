using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Day1
    {
        public static int Reverse(int x)
        {
            if(x>int.MaxValue/10||x<int.MinValue ) return 0;
            int reminder = 0;
            int result = 0;
           
            while (x > 0)
            {
                reminder = x % 10;
              
                x /= 10;
                result = result * 10 + reminder;
            }
            return result;
        }
    }
}
