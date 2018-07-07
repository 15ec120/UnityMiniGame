using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpCapsule : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = new Vector3(0, 20, 0);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
