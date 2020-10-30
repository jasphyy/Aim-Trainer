﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This class is used to handle name inputs from the game over scene.

public class NameInput : MonoBehaviour
{
    public InputField playerInput;
    private static string playerName;

    void Start()
    {
        playerInput = gameObject.GetComponent<InputField>();
        playerInput.onEndEdit.AddListener(getName);
    
    }

    void getName(string name)
    {
        setName(name);
    }

    void setName(string name)
    {
        playerName = name;
        Debug.Log(playerName);
    }
}
