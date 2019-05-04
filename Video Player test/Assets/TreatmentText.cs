using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TreatmentText : MonoBehaviour
{
    public TextMeshProUGUI treatmentOne;
    public TextMeshProUGUI treatmentTwo;
    public TextMeshProUGUI treatmentThree;
    public TextMeshProUGUI treatmentFour;

    public GameObject screenObject;
    private RandomizedTreatments randScript;



    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        randScript = screenObject.GetComponent<RandomizedTreatments>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
