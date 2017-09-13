using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tentaRise : MonoBehaviour {

	public GameObject Tentacruel;
	public Animator TentaAnim;
	// Use this for initialization
	void Start () {
		
		TentaAnim = Tentacruel.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Boat") {
			Debug.Log ("Here it is");
			TentaAnim.SetBool ("isColliding", true);
		}
	}
}
