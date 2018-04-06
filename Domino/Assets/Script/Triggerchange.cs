using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerchange : MonoBehaviour {

    public GameObject trgdomino;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Change()
    {
        Instantiate(trgdomino, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
