using Assets.Scripts.assignment26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    public class Duck : Creature, IRunnable, ISwimmable
    {
        override
        public void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }

        public void Run()
        {
            Debug.Log("Duck runs.");
        }

        public void Swim()
        {
            Debug.Log("Duck swims.");
        }
    }
}
