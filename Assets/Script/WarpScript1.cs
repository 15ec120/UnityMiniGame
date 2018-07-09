using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpScript1 : MonoBehaviour
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
        Player.transform.position = new Vector3(252, -17, 10);
        Destroy(gameObject);
    }
}
