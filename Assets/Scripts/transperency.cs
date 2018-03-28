using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transperency : MonoBehaviour {
    CanvasGroup Info;
    bool finish;

	// Use this for initialization
	void Start () {
        Info = GetComponent<CanvasGroup>();
        finish = false;
        Info.alpha = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (finish)
        {
            if (Info.alpha != 0)
                Info.alpha -= (float)0.4*Time.deltaTime;

        }
	}

    public void closeInfo()
    {
        finish = true;
    }
}
