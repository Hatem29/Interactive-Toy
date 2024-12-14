using Assets.Scripts.assignment26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26 
{
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            List<Creature> creatures = new List<Creature>();
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();
            creatures.Add(kangaroo);
            creatures.Add(duck);

            List<IRunnable> runnables = new List<IRunnable>();
            List<IJumpable> jumpables = new List<IJumpable>();
            List<ISwimmable> swimmables = new List<ISwimmable>();

            runnables.Add(kangaroo);
            runnables.Add(duck);
            jumpables.Add(kangaroo);
            swimmables.Add(duck);

            foreach(Creature creature in creatures)
                creature.Speak();

            foreach(IRunnable runnable in runnables)
                runnable.Run();

            foreach(IJumpable jumpable in jumpables)
                jumpable.Jump();

            foreach (ISwimmable swimmable in swimmables)
                swimmable.Swim();
        }
    }
}
