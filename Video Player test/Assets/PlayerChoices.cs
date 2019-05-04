using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerChoices
{
    public static Treat shortTreatOne { get; set; }
    public static Treat shortTreatTwo { get; set; }
    public static Treat shortTreatThree { get; set; }
    public static Treat shortTreatFour { get; set; }
    public static Treat longTreatOne { get; set; }
    public static Treat longTreatTwo { get; set; }
    public static Treat longTreatThree { get; set; }
    public static Treat longTreatFour { get; set; }
    public static int shortAssOne { get; set; }
    public static int shortAssTwo { get; set; }
    public static int shortAssThree { get; set; }
    public static int shortAssFour { get; set; }
    public static int longAssOne { get; set; } 
    public static int longAssTwo { get; set; }
    public static int longAssThree { get; set; }
    public static int longAssFour { get; set; }
    public static int currentMap { get; set; }
    public static int mapBranch { get; set; }
    public static bool secondPlaythrough { get; set; }





}
[System.Serializable]
public class Treat
{
    public string TreatmentCommon;
    public string TreatmentScience;
    public string Description;
    public string Category;
    public string Cost;
    public string Effective;
    public string Location;

}
