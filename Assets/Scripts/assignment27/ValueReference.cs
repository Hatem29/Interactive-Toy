using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ValueReference : MonoBehaviour
{
    void Start()
    {
        int a = 1, b = 2;
        ChangeByValue(a);
        Debug.Log(a);

        ChangeByRef(ref b);
        Debug.Log(b);

        int c;
        GiveValue(out c);
        Debug.Log(c);
    }

    void ChangeByValue(int vr)
    {
        vr += 10;
    }

    void ChangeByRef(ref int vr)
    {
        vr += 10;
    }

    void GiveValue(out int vr)
    {
        vr = 100;
    }
}
