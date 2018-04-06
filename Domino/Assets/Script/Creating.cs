using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creating : MonoBehaviour {
    public GameObject NewDomino;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    void Creat()
    {
        Instantiate(NewDomino, transform.position, transform.rotation);
    }
}
