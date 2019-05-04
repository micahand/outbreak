using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomTreatLong : MonoBehaviour
{
    public Image treatmentOne;
    public Image treatmentTwo;
    public Image treatmentThree;
    public Image treatmentFour;


    // Start is called before the first frame update
    void Start()
    {

        Treatment tat = new Treatment(0, "Test and Treat", "Test", "", 0.5f);
        Treatment ens = new Treatment(1, "Environmental Spraying", "Spraying_2", "", -0.5f);
        Treatment enc = new Treatment(2, "Environmental Control", "Control", "", 0.1f);
        Treatment laf = new Treatment(3, "Larvacidal Fish", "Fish", "", -0.5f);
        Treatment mlv = new Treatment(4, "Malaria Vaccine", "Vaccine", "", -0.5f);
        Treatment gar = new Treatment(5, "Garlic", "Garlic", "", -1);
        Treatment drt = new Treatment(6, "Avoid Dirt", "Dirt", "", -1);
        Treatment wat = new Treatment(7, "Dirty Water", "Water", "", -1);


        Treatment[] longReal = { tat, ens, enc, laf, mlv };
        Treatment[] longFake = { gar, drt, wat };

        int[] randShortInt = { 0, 1, 2, 3, 4 };
        randShortInt = ShuffleArray(randShortInt);

        int[] randFakeInt = { 0, 1, 2 };
        randFakeInt = ShuffleArray(randFakeInt);
        System.Random rand = new System.Random();

        treatmentOne.sprite = Resources.Load<Sprite>(longReal[randShortInt[0]].treatmentLocation);
        treatmentTwo.sprite = Resources.Load<Sprite>(longReal[randShortInt[1]].treatmentLocation);
        treatmentThree.sprite = Resources.Load<Sprite>(longReal[randShortInt[2]].treatmentLocation);
        treatmentFour.sprite = Resources.Load<Sprite>(longFake[randFakeInt[0]].treatmentLocation);


        PlayerChoices.longTreatOne = longReal[0];
        PlayerChoices.longTreatTwo = longReal[1];
        PlayerChoices.longTreatThree = longReal[2];
        PlayerChoices.longTreatFour = longFake[0];

    }
    int[] ShuffleArray(int[] array)
    {
        System.Random r = new System.Random();
        for (int i = array.Length; i > 0; i--)
        {
            int j = r.Next(i);
            int k = array[j];
            array[j] = array[i - 1];
            array[i - 1] = k;
        }
        return array;
    }
}
