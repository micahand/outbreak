using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disabler : MonoBehaviour
{
    public Button but;
    void Start()
    {
        if (PlayerChoices.secondPlaythrough)
        {
            but.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
