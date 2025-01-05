using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class Tester : MonoBehaviour
    {
        [SerializeField]
        int n;

        void Start()
        {
            int sum = Utilities.Add(10, 32, 5, 29, 13);
            Debug.Log(sum);

            Debug.Log("Hanno ".RepeatString(n));
        }
    }
}
