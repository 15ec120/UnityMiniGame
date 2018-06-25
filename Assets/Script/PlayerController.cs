using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    float speed = 60.0f;

    void Update()
    {
        
        float x = Input.acceleration.x;
        float z = Input.acceleration.y;
        
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(x * speed, 0, z * speed);
    }
}