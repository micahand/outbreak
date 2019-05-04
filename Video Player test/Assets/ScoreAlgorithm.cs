using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreAlgorithm : MonoBehaviour
{
    public TextMeshProUGUI scoreMessage;
    // Start is called before the first frame update
    void Start()
    {
        float score =
             Scaler(PlayerChoices.shortAssOne)*float.Parse(PlayerChoices.shortTreatOne.Effective) +
             Scaler(PlayerChoices.shortAssTwo) * float.Parse(PlayerChoices.shortTreatTwo.Effective) +
             Scaler(PlayerChoices.shortAssThree) * float.Parse(PlayerChoices.shortTreatThree.Effective) +
             Scaler(PlayerChoices.shortAssFour) * float.Parse(PlayerChoices.shortTreatFour.Effective) +
             Scaler(PlayerChoices.longAssOne) * float.Parse(PlayerChoices.longTreatOne.Effective) +
             Scaler(PlayerChoices.longAssTwo) * float.Parse(PlayerChoices.longTreatTwo.Effective) +
             Scaler(PlayerChoices.longAssThree) * float.Parse(PlayerChoices.longTreatThree.Effective) +
             Scaler(PlayerChoices.longAssFour) * float.Parse(PlayerChoices.longTreatFour.Effective);
        scoreMessage.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Scaler(int number)
    {
            
        if (number == 0 ) return 0;
        else if (number == 1) return 1;
        else if (number == 2) return 1.5f;
        else if (number == 3) return 1.75f;
        else if (number == 4) return 1.8f;
        else return 1.82f;

    }
}
