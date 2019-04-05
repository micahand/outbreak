using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomTreatLong : MonoBehaviour
{
    //private string jsonString;
    private string jsonShort;
    private string jsonLong;
    private string jsonShortFake;
    private string jsonLongFake;

    private Treat[] randTreatLong;
    private Treat[] randFakeLong;


    public TextMeshProUGUI treatmentOne;
    public TextMeshProUGUI treatmentTwo;
    public TextMeshProUGUI treatmentThree;
    public TextMeshProUGUI treatmentFour;

    public TextMeshProUGUI titleOne;
    public TextMeshProUGUI titleTwo;
    public TextMeshProUGUI titleThree;
    public TextMeshProUGUI titleFour;

    public SpriteRenderer topOneSprite;
    public SpriteRenderer topTwoSprite;
    public SpriteRenderer topThreeSprite;
    public SpriteRenderer topFourSprite;

    public SpriteRenderer botOneSprite;
    public SpriteRenderer botTwoSprite;
    public SpriteRenderer botThreeSprite;
    public SpriteRenderer botFourSprite;

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
        //call in this manner: treatmentLong[0].TreatmentCommon

        jsonShort = "{\"Treatments\":[{\"TreatmentCommon\":\"Mass Drug Administration\",\"TreatmentScience\":\"#82b92c\",\"Description\":\"Administration of drugs to whole populations irrespective of disease status.\",\"Category\":\"Treatment\",\"Cost\":\"300\",\"Effective\":\"4\",\"Location\":\"drugadmin\"},{\"TreatmentCommon\":\"Household spraying\",\"TreatmentScience\":\"Indoor Residual Spraying (IRS)\",\"Description\":\"Insecticides kill adult females while they rest on the walls of the house after a bloodmeal\",\"Category\":\"Vector Control\",\"Cost\":\"100\",\"Effective\":\"3\",\"Location\":\"housespray\"},{\"TreatmentCommon\":\"Insect Repellent\",\"TreatmentScience\":\"DEET\",\"Description\":\"Substance applied to skin, clothing, or other surfaces which repels insects\",\"Category\":\"Personal Protection Measure\",\"Cost\":\"200\",\"Effective\":\"3\",\"Location\":\"repel\"},{\"TreatmentCommon\":\"Clothing\",\"TreatmentScience\":\"Clothing\",\"Description\":\"Wearing long-sleeve shirts and pants prevents bites. One can further prevent bites by wearing clothing \",\"Category\":\"Personal Protection Measure\",\"Cost\":\"5000\",\"Effective\":\"3\",\"Location\":\"clothing\"},{\"TreatmentCommon\":\"Bed Nets\",\"TreatmentScience\":\"Long-lasting insecticidal bed nets (LLINs)\",\"Description\":\"Mosquito net impregnated with insecticide. The insecticide is cleverly bound within the fibres that make up the netting and is 'slow released' over a 4-5 year period.\",\"Category\":\"Vector Control/Personal Protection Measures\",\"Cost\":\"400\",\"Effective\":\"4\",\"Location\":\"bednet\"}]}";
        jsonLong = "{\"Treatments\":[{\"TreatmentCommon\":\"Test and Treat\",\"TreatmentScience\":\"Rapid Diagnostic Test (RDTs) +Artemisinin Combination Therapies (ACT)\",\"Description\":\"Diagnose malaria by detecting evidence of malaria parasites (antigens) in human blood.   Then kill the parasites\",\"Category\":\"Treatment\",\"Cost\":\"100\",\"Effective\":\"4\",\"Location\":\"rdt\"},{\"TreatmentCommon\":\"Environmental spraying\",\"TreatmentScience\":\"Using insectides to kill larvae\",\"Description\":\"Spray insecticide on breeding sites\",\"Category\":\"Vector Control\",\"Cost\":\"1000\",\"Effective\":\"2\",\"Location\":\"vector\"},{\"TreatmentCommon\":\"Environmental control\",\"TreatmentScience\":\"Drain Standing Water; clear vegetation from lakesides\",\"Description\":\"Prevent mosquitos from laying eggs or enabling predators to eat the larvae\",\"Category\":\"Environmental Controls\",\"Cost\":\"1000\",\"Effective\":\"3\",\"Location\":\"enroncon\"},{\"TreatmentCommon\":\"Larvicidal fish\",\"TreatmentScience\":\"Larvicidal fish\",\"Description\":\"In some areas, mosquito larvae breed in standing bodies of water.  Some species of fish eat the alrvae\",\"Category\":\"Environmental Controls\",\"Cost\":\"1000\",\"Effective\":\"3\",\"Location\":\"fish\"},{\"TreatmentCommon\":\"Malaria Vaccine\",\"TreatmentScience\":\"Anti-malarial vaccine\",\"Description\":\"A vaccine that is used to prevent malaria. The only approved vaccine as of 2015 is RTS,S. It requires four injections, and has a relatively low efficacy (26–50%)\",\"Category\":\"Prevention\",\"Cost\":\"100\",\"Effective\":\"2\",\"Location\":\"vac\"}]}";
        jsonShortFake = "{\"Treatments\":[{\"TreatmentCommon\":\"Drink gin and tonics\",\"TreatmentScience\":\"Drink gin and tonics\",\"Description\":\"In the early 1800's, British soldiers in India drank gin and tonics, containing quinine powder from cinchona bark, to prevent malaria. Tonic water produced today no longer includes high concentrations of quinine.\",\"Category\":\"Personal Protection Measures\",\"Cost\":\"4000\",\"Effective\":\"0\",\"Location\":\"gin\"},{\"TreatmentCommon\":\"Ultrasonic mosquito repellant\",\"TreatmentScience\":\"Ultrasonic mosquito repellant\",\"Description\":\"Electronic repellers that generate a high-frequency ultrasonic buzz to repel mosquitoes. There is no scientific proof that these work.\",\"Category\":\"Personal Protection Measures\",\"Cost\":\"3000\",\"Effective\":\"0\",\"Location\":\"sonic\"},{\"TreatmentCommon\":\"Don't eat mangoes\",\"TreatmentScience\":\"Don't eat mangoes\",\"Description\":\"In the DRC, fruits such as mangoes are more common in the rainy season. For this reason, people associate them with causing malara. \",\"Category\":\"Personal Protection Measures\",\"Cost\":\"100\",\"Effective\":\"0\",\"Location\":\"mango\"}]}";
        jsonLongFake = "{\n  \"Treatments\": [\n    {\n   \"TreatmentCommon\": \"Eat more garlic\",\n      \"TreatmentScience\": \"Eat more garlic\",\n      \"Description\": \"Though eating garlic does alter your body odor, there is no evidence that it makes you less attractive to female mosquitoes. \",\n      \"Category\":\"Personal Protection Measures\",\n      \"Cost\": \"100\",\n      \"Effective\": \"0\",\n      \"Location\": \"garlic\"\n    },\n     {\n   \"TreatmentCommon\": \"Avoid direct contact with dirt, such as in farming\",\n      \"TreatmentScience\": \"Avoid direct contact with dirt, such as in farming\",\n      \"Description\": \"Some believe having direct contact with dirt, such as in farming, is the cause of malaria. \",\n      \"Category\":\"Personal Protection Measures\",\n      \"Cost\": \"1000\",\n      \"Effective\": \"0\",\n      \"Location\": \"dirt\"\n    },\n    {\n   \"TreatmentCommon\": \"Don't drink dirty water\",\n      \"TreatmentScience\": \"Don't drink dirty water\",\n      \"Description\": \"Some believe that drinking dirty water makes you sick with malaria.\",\n      \"Category\":\"Personal Protection Measures\",\n      \"Cost\": \"1000\",\n      \"Effective\": \"0\",\n      \"Location\": \"dirtywater\"\n    }\n  ]\n}";

        Treat[] treatmentLong = JsonHelper.FromJson<Treat>(jsonLong);
        Treat[] treatmentLongFake = JsonHelper.FromJson<Treat>(jsonLongFake);


        int[] randShortInt = { 0, 1, 2, 3, 4 };
        randShortInt = ShuffleArray(randShortInt);

        int[] randFakeInt = { 0, 1, 2 };
        randFakeInt = ShuffleArray(randFakeInt);

        Treat[] randTreatLong = {
            treatmentLong[randShortInt[0]],treatmentLong[randShortInt[1]],treatmentLong[randShortInt[2]]
                };
        Treat[] randFakeLong = {
            treatmentLongFake[randFakeInt[0]]
                };


        treatmentOne.text = randTreatLong[0].Description;
        treatmentTwo.text = randTreatLong[1].Description;
        treatmentThree.text = randTreatLong[2].Description;
        treatmentFour.text = randFakeLong[0].Description;

        titleOne.text = randTreatLong[0].TreatmentCommon;
        titleTwo.text = randTreatLong[1].TreatmentCommon;
        titleThree.text = randTreatLong[2].TreatmentCommon;
        titleFour.text = randFakeLong[0].TreatmentCommon;


        Debug.Log(randTreatLong[0].Location);
        topOneSprite.sprite = Resources.Load<Sprite>(randTreatLong[0].Location);
        topTwoSprite.sprite = Resources.Load<Sprite>(randTreatLong[1].Location);
        topThreeSprite.sprite = Resources.Load<Sprite>(randTreatLong[2].Location);
        topFourSprite.sprite = Resources.Load<Sprite>(randFakeLong[0].Location);

        botOneSprite.sprite = Resources.Load<Sprite>(randTreatLong[0].Location);
        botTwoSprite.sprite = Resources.Load<Sprite>(randTreatLong[1].Location);
        botThreeSprite.sprite = Resources.Load<Sprite>(randTreatLong[2].Location);
        botFourSprite.sprite = Resources.Load<Sprite>(randFakeLong[0].Location);

        PlayerChoices.longTreatOne = randTreatLong[0];
        PlayerChoices.longTreatTwo = randTreatLong[1];
        PlayerChoices.longTreatThree = randTreatLong[2];
        PlayerChoices.longTreatFour = randFakeLong[0];

        Debug.Log(PlayerChoices.longTreatOne.TreatmentCommon);
        Debug.Log("hello");

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
