using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpScript3 : MonoBehaviour
{

    public GameObject particle;//Particleを宣言

    void OnTriggerEnter(Collider hit)
    {

        Instantiate(particle, transform.position, transform.rotation);
        Invoke("Warp", 3.0f);

    }
    void Warp()
    {
        GameObject Player = GameObject.Find("Player");
        Player.transform.position = new Vector3(-154, -12, 5);
        Destroy(gameObject);
    }
}
