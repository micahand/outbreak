using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondPlaythrough : MonoBehaviour
{
    public Button tryagain;
    public Button finish;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerChoices.secondPlaythrough)
        {
            tryagain.gameObject.SetActive(false);
            RectTransform transform = finish.gameObject.GetComponent<RectTransform>();
            Vector2 position = transform.anchoredPosition;
            transform.anchoredPosition = new Vector2(0, 10);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
