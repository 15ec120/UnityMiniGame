using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
<<<<<<< HEAD
=======
    // speedを制御する
    public float speed = 10;
>>>>>>> 15ec097

    float speed = 60.0f;

    void Update()
    {
        
        float x = Input.acceleration.x;
        float z = Input.acceleration.y;
        
        Rigidbody rigidbody = GetComponent<Rigidbody>();

<<<<<<< HEAD
=======
        // xとzにspeedを掛ける
>>>>>>> 15ec097
        rigidbody.AddForce(x * speed, 0, z * speed);
    }
}