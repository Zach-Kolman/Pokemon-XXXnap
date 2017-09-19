using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrossHairColor : MonoBehaviour {

   
    public RawImage crosshair;
   // public Color newColor;

    // Use this for initialization
    void Start () {
        crosshair = GetComponent<RawImage>();
       
        //newColor = GetComponent<Color>();
    }
	
	// Update is called once per frame
	public void Update () {
        

    }

    public void ChangeColor()
    {
        crosshair.color = Color.red;




    }

    public void ChangeWhite()
    {

        crosshair.color = Color.white;


    }
}
