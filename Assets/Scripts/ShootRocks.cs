using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRocks : MonoBehaviour {

   // public GameObject rockPlacement;
    public GameObject rock;
    public float rockForce;
    public Transform fireLocation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown("space"))
        {

            GameObject Temp_Rock;
            Temp_Rock = Instantiate(rock, fireLocation.transform.position, fireLocation.transform.rotation) as GameObject;

            Temp_Rock.transform.Rotate(Vector3.left * 90);

            Rigidbody Temp_RigidBody;
            Temp_RigidBody = Temp_Rock.GetComponent<Rigidbody>();

            Temp_RigidBody.AddForce(fireLocation.forward * rockForce);

            Destroy(Temp_Rock, 5.0f);







        }
		
	}
}
