using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpScript1 : MonoBehaviour {

    void OnTriggerEnter(Collider hit){
        hit.gameObject.transform.position = new Vector3(35, 3, 35);

        if (hit.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }

}
