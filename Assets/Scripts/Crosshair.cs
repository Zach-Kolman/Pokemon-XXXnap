using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour {

    Camera ourCam;
    CrossHairColor colorCross;
   public RawImage crosshair;
    public Color newColor;
    bool isOnTarget = false;

	// Use this for initialization
	void Start () {
        crosshair = GetComponent<RawImage>();
        ourCam = GetComponent<Camera>();
        colorCross = FindObjectOfType<CrossHairColor>();
       
       
	}

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray ray = ourCam.ScreenPointToRay(new Vector3(340, 200, 0));
        Debug.DrawRay(ray.origin, ray.direction, Color.green);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
               // hit.collider.enabled = false;
                colorCross.ChangeColor();
                isOnTarget = true;
                Debug.Log("You are aiming at POKE");
            }  else
            {
                colorCross.ChangeWhite();
            }
           
           
        }



    }
    }
