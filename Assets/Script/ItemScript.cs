using UnityEngine;
using System.Collections;

public class ItemScript : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            
            Destroy(gameObject);
        }
    }
}
