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
             Scaler(PlayerChoices.shortAssOne)* PlayerChoices.shortTreatOne.score +
             Scaler(PlayerChoices.shortAssTwo) * PlayerChoices.shortTreatTwo.score +
             Scaler(PlayerChoices.shortAssThree) * PlayerChoices.shortTreatThree.score +
             Scaler(PlayerChoices.shortAssFour) * PlayerChoices.shortTreatFour.score +
             Scaler(PlayerChoices.longAssOne) * PlayerChoices.longTreatOne.score +
             Scaler(PlayerChoices.longAssTwo) * PlayerChoices.longTreatTwo.score +
             Scaler(PlayerChoices.longAssThree) * PlayerChoices.longTreatThree.score +
             Scaler(PlayerChoices.longAssFour) * PlayerChoices.longTreatFour.score;
        score = score / 5;
        if (score >= 0.6) scoreMessage.text = "You got 5 Stars! Your'e a Malaria Master";
        if (score >= 0.2 && score < 0.6) scoreMessage.text = "You got 4 Stars! You're a Super Scientist";
        if (score >= -0.2 && score < 0.2) scoreMessage.text = "You got 3 Stars! You're an Accurate Analyst";
        if (score >=-0.6 && score < -0.2) scoreMessage.text = "You got 2 Stars! You're a Some Alliteration";
        if (score < -0.6) scoreMessage.text = "You got 1 Star. You suck!";

        Debug.Log(score);

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
