using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Assignment29
{

    public class ExceptionHandling : MonoBehaviour
    {

        void Start()
        {
            int playerScore = 100;
            int divisor = 0;

            try
            {
                Debug.Log("Attempting to calculate score multiplier...");

                int totalScore = playerScore / divisor;
            }
            catch (DivideByZeroException)
            {
                Debug.Log("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }
        }

    }
}