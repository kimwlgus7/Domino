using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCam : MonoBehaviour {
    public Transform Mytransform;
    public float horizontal = 0.0f;
    public float vertical = 0.0f;
    public float Movespeed = 5.0f;
    public float Rotatespeed = 100.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 moveDirect = (Vector3.forward * vertical) + (Vector3.right * horizontal);
        Mytransform.Translate(moveDirect.normalized * Time.deltaTime * Movespeed, Space.Self);
        Mytransform.Rotate(Vector3.up * Time.deltaTime * Rotatespeed * Input.GetAxis("Mouse X"));
    }
}
