using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDomino : MonoBehaviour {

    public float Power = 500;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForceAtPosition(transform.forward* Power, transform.position +new Vector3(0, 1, 0));
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
