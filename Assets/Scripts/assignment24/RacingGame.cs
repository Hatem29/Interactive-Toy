using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class RacingGame : MonoBehaviour
{
    public RaceState raceState;
    private RaceState currentRaceState;

    private void SimulateRace()
    {
        switch (raceState)
        { 
            default: 
                Debug.LogError("Unknown state."); 
                break;
            case RaceState.Start:
                Debug.Log("Race is starting.");
                break;
            case RaceState.Accelerate:
                Debug.Log("The car is accelrating.. ");
                break;
            case RaceState.Turn:
                Debug.Log("You are turning the car, be careful of your speed.");
                break;
            case RaceState.Crash:
                Debug.LogWarning("Your car is crashing!! watch out!");
                break;
            case RaceState.Finish:
                Debug.Log("You have succefully finished the race, now do it again..");
                break;
            
        }
    }

    void Update()
    {
        if (raceState != currentRaceState)
        {
            SimulateRace();
            currentRaceState = raceState;
        }
    }
}
