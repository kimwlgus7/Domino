using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {
	public bool camerastate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
		
	}
	public void _camera()
	{
		if (camerastate == true) 
		{
			gameObject.SetActive (true);
		}
	}
}
