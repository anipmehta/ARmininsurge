using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transitionafter : MonoBehaviour {
    CanvasGroup Info;
    bool trans;

    // Use this for initialization
    void Start()
    {
        Info = GetComponent<CanvasGroup>();
        trans = false;
        Info.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (trans)
        {
            if (Info.alpha != 1)
                Info.alpha += (float)0.4 * Time.deltaTime;

        }
    }

    public void closeInfo()
    {
        trans = true;
    }
}
