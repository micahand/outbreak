using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TryAgain : MonoBehaviour { 


    public void Proceed()
    {
        PlayerChoices.secondPlaythrough = true;
        SceneManager.LoadScene(1);
    }
}
