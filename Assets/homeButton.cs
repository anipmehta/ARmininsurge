using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class homeButton : MonoBehaviour {

    public void storyMode()
    {
        Debug.Log("<b>Switch to Story Mode</b>");
        SceneManager.LoadScene(0);
    }
}
