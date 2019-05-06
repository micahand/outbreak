using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class R2 : MonoBehaviour
{
    public GameObject screen;
    private Resource resourceScript;
    public Image resOne;


    private void Awake()
    {

        resourceScript = screen.GetComponent<Resource>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (resourceScript.resourceCount < 2)
        {
            resOne.color = new Color(1f, 1f, 1f, 0.5f);
        }
        else
        {
            resOne.color = new Color(1f, 1f, 1f, 1f);
        }
    }
}
