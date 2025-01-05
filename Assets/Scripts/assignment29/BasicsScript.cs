using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var st = "";
            var n = 1;
            var even = (n % 2 == 0 ? true : false);

            string ans;
            if (even) ans = "even";
            else ans = "odd";

            Debug.Log($"The number {n} is {ans}.");
            Debug.Log(System.DateTime.Now.Date);
            Debug.Log(System.DateTime.Now.TimeOfDay);
            Debug.Log(System.DateTime.Now.Day);
        }
    }
}
