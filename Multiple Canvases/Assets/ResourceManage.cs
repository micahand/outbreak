using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManage : MonoBehaviour
{
    public GameObject screen;
    private Resource resourceScript;
    private int count;
    public Button LeftButton;
    public Button RightButton;
    public Image[] resources;
    private int assigned = 0;

    private void Awake()
    {
        resourceScript = screen.GetComponent<Resource>();
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
        Debug.Log("Assigned Before Click Value Is: " + assigned);
        if (resourceScript.resourceCount > 0 && assigned < 5)
        {
            resourceScript.resourceCount--;
            resources[assigned].color = new Color(1f, 1f, 1f, 1f);
            assigned++;



        }
        Debug.Log("Assigned After Click Value Is: " + assigned);
    }
    void Increment()
    {
        Debug.Log("Assigned Value Before Click Is: " + assigned);
        if (resourceScript.resourceCount < 5 && assigned > 0)
        {
            assigned--;
            resourceScript.resourceCount++;
            resources[assigned].color = new Color(1f, 1f, 1f, 0f);
            
        }
        Debug.Log("Assigned Value After Click Is: " + assigned);

        Debug.Log(resourceScript.resourceCount);
    }
}
