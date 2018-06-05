using UnityEngine;
using System.Collections;

public class PlayerController2 : MonoBehaviour
{

    float speed = 15.0f;

    void Update()
    {
        var dir = Vector3.zero;
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        if (dir.sqrMagnitude > 1)
        {
            dir.Normalize();
        }

        dir *= Time.deltaTime;

        transform.Translate(dir * speed);
    }
}