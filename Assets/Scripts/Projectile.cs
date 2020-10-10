using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD


public class Projectile : MonoBehaviour
{

   
    public static float bottomY = -13.90522f;                                  // a
    
   
=======
public class Projectile : MonoBehaviour
{
    public static float bottomY = -13.90522f;                                  // a
>>>>>>> parent of ff424be... GUI
=======
public class Projectile : MonoBehaviour
{
    public static float bottomY = -13.90522f;                                  // a
>>>>>>> parent of ff424be... GUI
=======
public class Projectile : MonoBehaviour
{
    public static float bottomY = -13.90522f;                                  // a
>>>>>>> parent of ff424be... GUI
=======
public class Projectile : MonoBehaviour
{
    public static float bottomY = -13.90522f;                                  // a
>>>>>>> parent of ff424be... GUI
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Rotator.addCount();
        }
    }

    
=======
=======
>>>>>>> parent of ff424be... GUI
=======
>>>>>>> parent of ff424be... GUI
=======
>>>>>>> parent of ff424be... GUI
        }
    }
>>>>>>> parent of ff424be... GUI
}

