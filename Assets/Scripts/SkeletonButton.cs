using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkeletonButton : MonoBehaviour {

    public void ButtonAction()
    {
        Debug.Log("<b>Switch to Skeleton Mode</b>");
        SceneManager.LoadScene(0);
    }
    
}
