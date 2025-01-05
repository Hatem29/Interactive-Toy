using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TestCustomObject : MonoBehaviour
    {
        CustomObject customObject1, customObject2;
        void Start()
        {
            customObject1 = new CustomObject(1, "box");
            print(customObject1);

            //customObject2 = new CustomObject(2, "box");
            //string ans;
            ////if (customObject1 == customObject2) ans = "Same objects";
            ////else ans = "Different objects";
            ////print(ans);

        }
    }
}
