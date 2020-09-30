﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void Back ()
    {
        Debug.Log("Going Back to main scene...");
        SceneManager.LoadScene("Main");
    }
}
