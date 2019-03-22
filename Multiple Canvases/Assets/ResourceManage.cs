using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManage : MonoBehaviour
{
    public GameObject screenObject;
    private Resource resourceScript;
    private int count;
    public Button LeftButton;
    public Button RightButton;


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
    }

    void Decrement()
    {
        Debug.Log("Right Clicked");
        if (resourceScript.resourceCount > 0)
        {
            resourceScript.resourceCount--;
        }
        Debug.Log(resourceScript.resourceCount);
    }
    void Increment()
    {
        Debug.Log("Left Clicked");
        if (resourceScript.resourceCount < 5)
        {
            resourceScript.resourceCount++;
        }
        Debug.Log(resourceScript.resourceCount);
    }
}
