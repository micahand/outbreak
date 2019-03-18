using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R1 : MonoBehaviour
{

    private resource resourceScript;
    private int count;
    private SpriteRenderer resOne;


    private void Awake()
    {
        resourceScript = GetComponent<resource>();
        count = resourceScript.resourceCount;

        resOne = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (count == 0)
        {
            resOne.color = new Color(1f, 1f, 1f, 0f);
        }
    }
}
