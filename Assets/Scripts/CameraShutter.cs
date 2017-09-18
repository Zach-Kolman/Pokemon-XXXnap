using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShutter : MonoBehaviour {

	public GameObject topShut;
	public GameObject botShut;

	private Animator topShutAnim;
	private Animator botShutAnim;

	// Use this for initialization
	void Start () {

		topShutAnim = topShut.GetComponent<Animator> ();
		botShutAnim = botShut.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.E)) {
			StartCoroutine ("topShutMove");
			StartCoroutine ("botShutMove");
			new WaitForSeconds (1);
			ScreenCapture.CaptureScreenshot ("C:/Users/Zach/TestPic.png");
			}
	}

	IEnumerator topShutMove()
	{
		topShutAnim.SetBool ("hasPressed", true);
		yield return new WaitForSeconds (0.5f);
		topShutAnim.SetBool ("hasPressed", false);
		yield return null;

	}

	IEnumerator botShutMove()
	{
		botShutAnim.SetBool ("hasPressed", true);
		yield return new WaitForSeconds (0.5f);
		botShutAnim.SetBool ("hasPressed", false);
		yield return null;
	}
}
