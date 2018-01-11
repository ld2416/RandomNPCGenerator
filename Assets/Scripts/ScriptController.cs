﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptController : MonoBehaviour {

    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for " + name);
        SceneManager.LoadScene(name);
    }

    public void QuitGame()
    {
        Debug.Log("Quit game request received.");
        Application.Quit();
    }
}
