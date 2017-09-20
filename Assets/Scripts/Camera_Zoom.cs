using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Zoom : MonoBehaviour {

    int camZoom = 10;
    int camNormal = 60;
    float smooth = 5;

    private bool isZoomed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetMouseButton(0))
        {

            isZoomed = true;
        }

        if (Input.GetMouseButton(1))
        {

            isZoomed = false;
        }

        if (isZoomed)
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, camZoom, Time.deltaTime * smooth);

        }
        if (!isZoomed)
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, camNormal, Time.deltaTime * smooth);

        }
	}
}
