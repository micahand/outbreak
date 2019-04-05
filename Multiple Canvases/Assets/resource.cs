using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resource : MonoBehaviour
{
    // Start is called before the first frame update
    public int resourceCount = 5;
    public Button submit;

    private void Awake()
    {
        resourceCount = 5;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resourceCount != 0){
            submit.interactable = false;
        }
        else
        {
            submit.interactable = true;
        }
    }
}
