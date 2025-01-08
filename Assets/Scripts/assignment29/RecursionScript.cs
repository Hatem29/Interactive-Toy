using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionScript : MonoBehaviour
{

    void Start()
    {
        print("Recursive");
        print(FibonacciRecursive(10));
        print(FibonacciRecursive(30));

        print("Iterative");
        print(FibonacciIterative(10));
        print(FibonacciIterative(30));
    }

    int FibonacciRecursive(int n)
    {
        if (n <= 0)
            return 0;
        if (n == 1)
            return 1;
        
        int a = FibonacciRecursive(n - 1);
        int b = FibonacciRecursive(n - 2);

        return a + b;
    }

    int FibonacciIterative(int n)
    {
        int a = 0, b = 1;
        for(int i = 2; i <= n; i++)
        {
            int c = a + b;
            a = b; b = c;
        }

        return b;
    }
}
