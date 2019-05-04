using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShortTreatTwo : MonoBehaviour
{
    public GameObject screenObject;
    private Resource resourceScript;
    private int count;
    public Button LeftButton;
    public Button RightButton;
    public Image[] resources;
    private int assigned = 0;

    private void Awake()
    {
        resourceScript = screenObject.GetComponent<Resource>();
        count = resourceScript.resourceCount;

    }
    // Start is called before the first frame update
    void Start()
    {
        LeftButton.onClick.AddListener(Increment);
        RightButton.onClick.AddListener(Decrement);
    }

    // Update is called once per frame
    void Update()
    {
        count = resourceScript.resourceCount;
        if (assigned == 0)
        {
            LeftButton.interactable = false;
        }
        else if (assigned == 5)
        {
            RightButton.interactable = false;
        }
        else
        {
            RightButton.interactable = true;
            LeftButton.interactable = true;
        }
    }

    void Decrement()
    {
        if (resourceScript.resourceCount > 0 && assigned < 5)
        {
            resourceScript.resourceCount--;
            resources[assigned].color = new Color(1f, 1f, 1f, 1f);
            assigned++;
            PlayerChoices.shortAssTwo++;



        }
    }
    void Increment()
    {
        if (resourceScript.resourceCount < 5 && assigned > 0)
        {
            assigned--;
            resourceScript.resourceCount++;
            resources[assigned].color = new Color(1f, 1f, 1f, 0f);
            PlayerChoices.shortAssTwo--;

        }
    }
}
