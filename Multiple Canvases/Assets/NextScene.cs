﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void Proceed () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void setPlaythrough()
    {
        PlayerChoices.secondPlaythrough = true;
        PlayerChoices.currentMap = 4;
    }
}
