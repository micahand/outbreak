    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLongScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     float score = Scaler(PlayerChoices.longAssOne) *PlayerChoices.longTreatOne.score +
             Scaler(PlayerChoices.longAssTwo) * PlayerChoices.longTreatTwo.score +
             Scaler(PlayerChoices.longAssThree) * PlayerChoices.longTreatThree.score +
             Scaler(PlayerChoices.longAssFour) * PlayerChoices.longTreatFour.score;
        PlayerChoices.score = score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Scaler(int number)
    {

        if (number == 0) return 0;
        else if (number == 1) return 1;
        else if (number == 2) return 1.5f;
        else if (number == 3) return 1.75f;
        else if (number == 4) return 1.8f;
        else return 1.82f;

    }
}
