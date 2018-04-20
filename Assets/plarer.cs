using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plarer : MonoBehaviour {
    public float speed;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        float y = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        transform.Rotate(new Vector3(0, y, 0));
	}
}
