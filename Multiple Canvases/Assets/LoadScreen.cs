using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScreen : MonoBehaviour
{
    public GameObject panel;
    public Sprite[] blue;
    public Sprite[] red;
    public Sprite[] green;


    void Start()
    {

        if (PlayerChoices.mapBranch == 0)
        {
            panel.GetComponent<Image>().sprite = blue[PlayerChoices.currentMap];
        }
        if (PlayerChoices.mapBranch == 1)
        {
            panel.GetComponent<Image>().sprite = red[PlayerChoices.currentMap];
        }
        if (PlayerChoices.mapBranch == 2)
        {
            panel.GetComponent<Image>().sprite = green[PlayerChoices.currentMap];
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
