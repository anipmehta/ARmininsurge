using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransparencySlider : MonoBehaviour {
    public Slider transparencySlider;
    public GameObject head;
    public Renderer headRenderer;
	// Use this for initialization
	void Start () {

         head = GameObject.Find("head");

        headRenderer = head.GetComponent<Renderer>();
        transparencySlider.onValueChanged.AddListener(delegate { changeTrans(); });
	}

    public void changeTrans()
    {
         Color color = headRenderer.material.color;
         color.a -= transparencySlider.value;
         Debug.Log(color.a);
         headRenderer.material.color = new Color(1, 1, 1, transparencySlider.value);
        // Debug.Log(transparencySlider.value);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
