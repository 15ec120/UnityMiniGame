using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed = 10;



    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();


        // xとzにspeedを掛ける

        rigidbody.AddForce(x * speed, 0, z * speed);
    }
}