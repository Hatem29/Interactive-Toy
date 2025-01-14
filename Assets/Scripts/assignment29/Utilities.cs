using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public static string RepeatString(this string str, int count)
        {
            string ans = "";
            for (int i = 0; i < count; i++)
                ans += str;

            return ans;
        }
    }
}
