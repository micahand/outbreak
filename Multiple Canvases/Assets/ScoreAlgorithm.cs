using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAlgorithm : MonoBehaviour
{
    public TextMeshProUGUI scoreMessage;
    public Image[] stars;
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
        if (score >= 0.6)
        {
            scoreMessage.text = "You are the Malaria Master! Your choices have really helped Stop the Outbreak and have saved thousands of lives in the Democratic Republic of Congo. Great job!";
            for(int i = 0;i <5; i++)
            {
                stars[i].sprite = Resources.Load<Sprite>("Star_Full");
            }
        }
        if (score >= 0.2 && score < 0.6)
        {
            scoreMessage.text = "You are a Combat Champ! Your choices were good and have helped reduce the spread of this deadly disease—but can you Stop the Outbreak entirely? Play again to find out!";
            for (int i = 0; i < 4; i++)
            {
                stars[i].sprite = Resources.Load<Sprite>("Star_Full");
            }
        }
        if (score >= -0.2 && score < 0.2)
        {
            scoreMessage.text = "You are a Combat Champ! Your choices were good and have helped reduce the spread of this deadly disease—but can you Stop the Outbreak entirely? Play again to find out!";
            for (int i = 0; i < 3; i++)
            {
                stars[i].sprite = Resources.Load<Sprite>("Star_Full");
            }
        }
        if (score >= -0.6 && score < -0.2)
        {
            scoreMessage.text = "Keep trying! Use what you have just learned to see if you can find the best treatment options that will help Stop the Outbreak.";
            for (int i = 0; i < 2; i++)
            {
                stars[i].sprite = Resources.Load<Sprite>("Star_Full");
            }
        }
        if (score < -0.6)
        {
            scoreMessage.text = "Keep trying! Use what you have just learned to see if you can find the best treatment options that will help Stop the Outbreak.";
            for (int i = 0; i < 1; i++)
            {
                stars[i].sprite = Resources.Load<Sprite>("Star_Full");
            }
        }

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
