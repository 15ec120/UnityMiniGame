using UnityEngine;
using System.Collections;

public class Rolling : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 2, 0));　//y軸方向に回転
    }
}