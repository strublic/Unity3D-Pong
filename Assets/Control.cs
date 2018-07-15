using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float speed = .3f;

        if (gameObject.name == "Bump1")
            transform.Translate(0, Input.GetAxis("Horizontal") * speed, 0);
        else
            transform.Translate(0, Input.GetAxis("Vertical") * speed, 0);
    }
}
