using UnityEngine;
using System.Collections;

public class WarpPoint : MonoBehaviour
{

    // ★改良
    public Vector3 pos;

    void OnTriggerEnter(Collider other)
    {

        // ★改良
        other.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}