using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Threading;
using TMPro;



public class RandomizedTreatments : MonoBehaviour
{
    //private string jsonString;
    private string jsonShort;
    private string jsonLong;
    private string jsonShortFake;
    private string jsonLongFake;

    private Treat[] randTreatShort;
    private Treat[] randTreatLong;
    private Treat[] randFakeLong;
    private Treat[] randFakeShort;

    public TextMeshProUGUI treatmentOne;
    public TextMeshProUGUI treatmentTwo;
    public TextMeshProUGUI treatmentThree;
    public TextMeshProUGUI treatmentFour;

    public TextMeshProUGUI titleOne;
    public TextMeshProUGUI titleTwo;
    public TextMeshProUGUI titleThree;
    public TextMeshProUGUI titleFour;

    // Start is called before the first frame update
    void Start()
    {

        //Available features you can call
        /*
   public string TreatmentCommon;
   public string TreatmentScience;
   public string Description;
   public string Category;
   public string Cost;
   public string Effective;      
   */
        //call in this manner: treatmentShort[0].TreatmentCommon

        jsonShort = "{\"Treatments\":[{\"TreatmentCommon\":\"Mass Drug Administration\",\"TreatmentScience\":\"#82b92c\",\"Description\":\"Administration of drugs to whole populations irrespective of disease status.\",\"Category\":\"Treatment\",\"Cost\":\"300\",\"Effective\":\"4\",\"Location\":\"./treatment1.png\"},{\"TreatmentCommon\":\"Household spraying\",\"TreatmentScience\":\"Indoor Residual Spraying (IRS)\",\"Description\":\"Insecticides kill adult females while they rest on the walls of the house after a bloodmeal\",\"Category\":\"Vector Control\",\"Cost\":\"100\",\"Effective\":\"3\",\"Location\":\"./treatment2.png\"},{\"TreatmentCommon\":\"Insect Repellent\",\"TreatmentScience\":\"DEET\",\"Description\":\"Substance applied to skin, clothing, or other surfaces which repels insects\",\"Category\":\"Personal Protection Measure\",\"Cost\":\"200\",\"Effective\":\"3\",\"Location\":\"./treatment3.png\"},{\"TreatmentCommon\":\"Clothing\",\"TreatmentScience\":\"Clothing\",\"Description\":\"Wearing long-sleeve shirts and pants prevents bites. One can further prevent bites by wearing clothing \",\"Category\":\"Personal Protection Measure\",\"Cost\":\"5000\",\"Effective\":\"3\",\"Location\":\"./treatment4.png\"},{\"TreatmentCommon\":\"Bed Nets\",\"TreatmentScience\":\"Long-lasting insecticidal bed nets (LLINs)\",\"Description\":\"Mosquito net impregnated with insecticide. The insecticide is cleverly bound within the fibres that make up the netting and is 'slow released' over a 4-5 year period.\",\"Category\":\"Vector Control/Personal Protection Measures\",\"Cost\":\"400\",\"Effective\":\"4\",\"Location\":\"./treatment5.png\"}]}";
        jsonLong = "{\"Treatments\":[{\"TreatmentCommon\":\"Test and Treat\",\"TreatmentScience\":\"Rapid Diagnostic Test (RDTs) +Artemisinin Combination Therapies (ACT)\",\"Description\":\"Diagnose malaria by detecting evidence of malaria parasites (antigens) in human blood.   Then kill the parasites\",\"Category\":\"Treatment\",\"Cost\":\"100\",\"Effective\":\"4\",\"Location\":\"./treatment6.png\"},{\"TreatmentCommon\":\"Environmental spraying\",\"TreatmentScience\":\"Using insectides to kill larvae\",\"Description\":\"Spray insecticide on breeding sites\",\"Category\":\"Vector Control\",\"Cost\":\"1000\",\"Effective\":\"2\",\"Location\":\"./treatment6.png\"},{\"TreatmentCommon\":\"Environmental control\",\"TreatmentScience\":\"Drain Standing Water; clear vegetation from lakesides\",\"Description\":\"Prevent mosquitos from laying eggs or enabling predators to eat the larvae\",\"Category\":\"Environmental Controls\",\"Cost\":\"1000\",\"Effective\":\"3\",\"Location\":\"./treatment7.png\"},{\"TreatmentCommon\":\"Larvicidal fish\",\"TreatmentScience\":\"Larvicidal fish\",\"Description\":\"In some areas, mosquito larvae breed in standing bodies of water.  Some species of fish eat the alrvae\",\"Category\":\"Environmental Controls\",\"Cost\":\"1000\",\"Effective\":\"3\",\"Location\":\"./treatment8.png\"},{\"TreatmentCommon\":\"Malaria Vaccine\",\"TreatmentScience\":\"Anti-malarial vaccine\",\"Description\":\"A vaccine that is used to prevent malaria. The only approved vaccine as of 2015 is RTS,S. It requires four injections, and has a relatively low efficacy (26–50%)\",\"Category\":\"Prevention\",\"Cost\":\"100\",\"Effective\":\"2\",\"Location\":\"./treatment9.png\"}]}";
        jsonShortFake = "{\"Treatments\":[{\"TreatmentCommon\":\"Drink gin and tonics\",\"TreatmentScience\":\"Drink gin and tonics\",\"Description\":\"In the early 1800's, British soldiers in India drank gin and tonics, containing quinine powder from cinchona bark, to prevent malaria. Tonic water produced today no longer includes high concentrations of quinine.\",\"Category\":\"Personal Protection Measures\",\"Cost\":\"4000\",\"Effective\":\"0\",\"Location\":\"./treatment10.png\"},{\"TreatmentCommon\":\"Ultrasonic mosquito repellant\",\"TreatmentScience\":\"Ultrasonic mosquito repellant\",\"Description\":\"Electronic repellers that generate a high-frequency ultrasonic buzz to repel mosquitoes. There is no scientific proof that these work.\",\"Category\":\"Personal Protection Measures\",\"Cost\":\"3000\",\"Effective\":\"0\",\"Location\":\"./treatment10.png\"},{\"TreatmentCommon\":\"Don't eat mangoes\",\"TreatmentScience\":\"Don't eat mangoes\",\"Description\":\"In the DRC, fruits such as mangoes are more common in the rainy season. For this reason, people associate them with causing malara. \",\"Category\":\"Personal Protection Measures\",\"Cost\":\"100\",\"Effective\":\"0\",\"Location\":\"./treatment11.png\"}]}";
        jsonLongFake = "{\n  \"Treatments\": [\n    {\n   \"TreatmentCommon\": \"Eat more garlic\",\n      \"TreatmentScience\": \"Eat more garlic\",\n      \"Description\": \"Though eating garlic does alter your body odor, there is no evidence that it makes you less attractive to female mosquitoes. \",\n      \"Category\":\"Personal Protection Measures\",\n      \"Cost\": \"100\",\n      \"Effective\": \"0\",\n      \"Location\": \"./treatment12.png\"\n    },\n     {\n   \"TreatmentCommon\": \"Avoid direct contact with dirt, such as in farming\",\n      \"TreatmentScience\": \"Avoid direct contact with dirt, such as in farming\",\n      \"Description\": \"Some believe having direct contact with dirt, such as in farming, is the cause of malaria. \",\n      \"Category\":\"Personal Protection Measures\",\n      \"Cost\": \"1000\",\n      \"Effective\": \"0\",\n      \"Location\": \"./treatment13.png\"\n    },\n    {\n   \"TreatmentCommon\": \"Don't drink dirty water\",\n      \"TreatmentScience\": \"Don't drink dirty water\",\n      \"Description\": \"Some believe that drinking dirty water makes you sick with malaria.\",\n      \"Category\":\"Personal Protection Measures\",\n      \"Cost\": \"1000\",\n      \"Effective\": \"0\",\n      \"Location\": \"./treatment14.png\"\n    }\n  ]\n}";

        Treat[] treatmentShort = JsonHelper.FromJson<Treat>(jsonShort);
        Treat[] treatmentLong = JsonHelper.FromJson<Treat>(jsonLong);
        Treat[] treatmentShortFake = JsonHelper.FromJson<Treat>(jsonShortFake);
        Treat[] treatmentLongFake = JsonHelper.FromJson<Treat>(jsonLongFake);


        int[] randShortInt = { 0, 1, 2, 3, 4 };
        randShortInt = ShuffleArray(randShortInt);

        int[] randFakeInt = { 0, 1, 2};
        randFakeInt = ShuffleArray(randFakeInt);
        
       Treat[] randTreatShort = {
            treatmentShort[randShortInt[0]],treatmentShort[randShortInt[1]],treatmentShort[randShortInt[2]]
                };
       Treat[] randFakeShort = {
            treatmentShortFake[randFakeInt[0]]
                };


        treatmentOne.text = randTreatShort[0].Description;
        treatmentTwo.text = randTreatShort[1].Description;
        treatmentThree.text = randTreatShort[2].Description;
        treatmentFour.text = randFakeShort[0].Description;

        titleOne.text = randTreatShort[0].TreatmentCommon;
        titleTwo.text = randTreatShort[1].TreatmentCommon;
        titleThree.text = randTreatShort[2].TreatmentCommon;
        titleFour.text = randFakeShort[0].TreatmentCommon;


        // Update is called once per frame
        void Update()
        {   

        }

       
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

    }
    public static class JsonHelper
    {
        public static T[] FromJson<T>(string json)
        {
            Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
            return wrapper.Treatments;
        }

        public static string ToJson<T>(T[] array)
        {
            Wrapper<T> wrapper = new Wrapper<T>();
            wrapper.Treatments = array;
            return JsonUtility.ToJson(wrapper);
        }

        public static string ToJson<T>(T[] array, bool prettyPrint)
        {
            Wrapper<T> wrapper = new Wrapper<T>();
            wrapper.Treatments = array;
            return JsonUtility.ToJson(wrapper, prettyPrint);
        }

        [System.Serializable]
        private class Wrapper<T>
        {
            public T[] Treatments;
        }
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