using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoChange : MonoBehaviour {
	public GameObject MovingDomino;


    // Use this for initialization
    void Start()
    {
    }



	// Update is called once per frame
	void Update () {
		
	}
	public void Change()
	{
		Instantiate (MovingDomino, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}
