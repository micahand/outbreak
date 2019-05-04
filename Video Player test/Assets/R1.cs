using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R1 : MonoBehaviour
{
    public GameObject screenObject;
    private Resource resourceScript;
    private SpriteRenderer resOne;


    private void Awake()
    {

        resourceScript = screenObject.GetComponent<Resource>();
        resOne = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
    if (resourceScript.resourceCount == 0)
        {
            resOne.color = new Color(1f, 1f, 1f, 0f);
        }
    else
        {
            resOne.color = new Color(1f, 1f, 1f, 1f);
        }
    }
}
