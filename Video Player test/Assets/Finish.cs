﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public void Proceed()
    {
        PlayerChoices.currentMap = 4;
        SceneManager.LoadScene(0);
    }
}
