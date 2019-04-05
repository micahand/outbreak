using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadIniMap : MonoBehaviour
{
    public GameObject panel;
    public Sprite[] blue;
    public Sprite[] red;
    public Sprite[] green;


    void Start()
    {
        System.Random gen = new System.Random();

        int colorSelect = gen.Next(0, 2);
        int startSelect = gen.Next(3, 5);

        if (colorSelect == 0)
        {
            panel.GetComponent<Image>().sprite= blue[startSelect];
        }
        if (colorSelect == 1)
        {
            panel.GetComponent<Image>().sprite = red[startSelect];
        }
        if (colorSelect == 2)
        {
            panel.GetComponent<Image>().sprite = green[startSelect];
        }
        PlayerChoices.currentMap = startSelect;
        PlayerChoices.mapBranch = colorSelect;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
