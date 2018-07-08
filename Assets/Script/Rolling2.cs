using UnityEngine;
using System.Collections;

public class Rolling2 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, -2, 0));　//y軸方向に回転
    }
}