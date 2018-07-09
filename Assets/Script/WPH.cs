using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPH: MonoBehaviour
{

    void OnTriggerEnter(Collider hit)
    {
        hit.gameObject.transform.position = new Vector3(-45, 3, -45);

        if (hit.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
