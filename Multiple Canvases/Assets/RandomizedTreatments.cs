using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using System.Threading;
using TMPro;




public class RandomizedTreatments : MonoBehaviour
{
    public Image treatmentOne;
    public Image treatmentTwo;
    public Image treatmentThree;
    public Image treatmentFour;


    // Start is called before the first frame update
    void Start()
    {

        Treatment mda = new Treatment(0, "Mass Drug Admin", "Mass_Drug", "", 0.5f);
        Treatment hhp = new Treatment(1, "House Hold Spraying", "Spraying_1", "", 0.1f);
        Treatment inr = new Treatment(2, "Insect Repellant", "Repellent", "", 0.1f);
        Treatment clo = new Treatment(3, "Clothing", "Clothing", "", 0.1f);
        Treatment bdn = new Treatment(4, "Bed Nets", "Bednet", "", 0.5f);
        Treatment gin = new Treatment(5, "Gin", "Tonic", "", -1);
        Treatment uts = new Treatment(6, "UltraSonic", "Ultrasonic", "", -1);
        Treatment man = new Treatment(7, "Mangos", "Mangos", "", -1);


        Treatment[] shortReal = { mda, hhp, inr, clo, bdn };
        Treatment[] shortFake = { gin, uts, man };

        int[] randShortInt = { 0, 1, 2, 3, 4 };
        randShortInt = ShuffleArray(randShortInt);

        int[] randFakeInt = { 0, 1, 2 };
        randFakeInt = ShuffleArray(randFakeInt);
        System.Random rand = new System.Random();

        treatmentOne.sprite = Resources.Load<Sprite>(shortReal[randShortInt[0]].treatmentLocation);
        treatmentTwo.sprite = Resources.Load<Sprite>(shortReal[randShortInt[1]].treatmentLocation);
        treatmentThree.sprite = Resources.Load<Sprite>(shortReal[randShortInt[2]].treatmentLocation);
        treatmentFour.sprite = Resources.Load<Sprite>(shortFake[randFakeInt[0]].treatmentLocation);


        PlayerChoices.shortTreatOne = shortReal[0];
        PlayerChoices.shortTreatTwo = shortReal[1];
        PlayerChoices.shortTreatThree = shortReal[2];
        PlayerChoices.shortTreatFour = shortFake[0];
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