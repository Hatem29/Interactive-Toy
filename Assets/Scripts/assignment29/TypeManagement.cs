using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TypeManagement : MonoBehaviour
    {

        void Start()
        {
            Animal animal = new Cat();
            animal.MakeSound();
            animal.Move();

            Cat cat = (Cat)animal;
            cat.MakeSound();
            cat.Move();

            List<ICanFight> fighters = new List<ICanFight>();
            fighters.Add(cat);
            fighters.Add(new Warrior());

            foreach (ICanFight f in fighters)
            {
                f.Attack();
                if (f is Cat)
                    Debug.Log("The object is a Cat.");
                else if (f is Warrior)
                    Debug.Log("The object is a Warrior.");
            }
        }
    }
}