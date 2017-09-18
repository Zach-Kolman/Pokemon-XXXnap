using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorScript : MonoBehaviour {
	public float moveSpeed;
	public Vector3 userDirection = Vector3.right;
	public float timeLeft;
	public GameObject dest;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		timeLeft -= Time.deltaTime;
	
		transform.Translate (userDirection * moveSpeed * Time.deltaTime); 

		if (timeLeft <= 0.0f) {
			StartCoroutine ("beltStop");
		}

	}

		IEnumerator beltStop()
		{
			moveSpeed = 0;
			timeLeft = 0;
			yield return new WaitForSeconds(0.55f);
			timeLeft = 0.05f;
			moveSpeed = 3.2f;
			yield return null;
		}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "TP1") {
			transform.position = dest.transform.position;
		}
	}
}
