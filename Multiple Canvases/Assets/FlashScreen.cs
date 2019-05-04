using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    public Sprite[] blue;
    public Sprite[] red;
    public Sprite[] green;


    IEnumerator Start()
    {
        Debug.Log(PlayerChoices.currentMap);
        Debug.Log(PlayerChoices.mapBranch);
        yield return StartCoroutine("FlashRedAndGreen");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator FlashRedAndGreen()
    {
        // suspend execution for 5 seconds
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
        panel.GetComponent<Image>().color = new Color(1f, 0f, 0f);
        yield return new WaitForSeconds(1f);
        if (PlayerChoices.score > 0)
        {
            PlayerChoices.currentMap--;
        }
        else
        {
            PlayerChoices.currentMap++;
        }
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
        panel.GetComponent<Image>().color = new Color(1f, 1f, 1f);


    }
}

