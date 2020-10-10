using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Projectile : MonoBehaviour
{
    public static float bottomY = -13.90522f;                                  // a
    void Update()
    {

        
        if (transform.position.y == bottomY)
        {
            Destroy(this.gameObject);                                      // b
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }
    }
}

