using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public Transform Mytrans;
    public float horizontal = 0.0f;
    public float vertical = 0.0f;
    public float Movespeed = 5.0f;
    public float Rotatespeed = 100.0f;
    public GameObject triggerdomino;
    public GameObject last;

    // Use this for initialization
    void Start () {
        Mytrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 moveDirect = (Vector3.forward * vertical) + (Vector3.right * horizontal);
        Mytrans.Translate(moveDirect.normalized * Time.deltaTime * Movespeed, Space.Self);
        Mytrans.Rotate(Vector3.up * Time.deltaTime * Rotatespeed * Input.GetAxis("Mouse X"));
        if (Input.GetKeyUp("space"))
        {
            //Debug.Log ("SEX");
            GameObject.Find("Cam").transform.Find("MainCamera").gameObject.SetActive(true);
            Destroy(gameObject);
            Instantiate(last, transform.position, transform.rotation);
        }
    }
    public void Change()
    {
        Instantiate(triggerdomino, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
