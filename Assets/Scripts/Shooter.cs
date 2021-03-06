﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{



    [Header("Set in Inspector")]                                            
    public GameObject prefabProjectile;
    public float velocityMult = 8f;
   
    // fields set dynamically
       [Header("Set Dynamically")]                                             
    public GameObject launchPoint;
    public Vector3 launchPos;                                  
    public GameObject projectile;                               
    public bool aimingMode;
    private Rigidbody projectileRigidbody;







    // Update is called once per frame
    void Update()
    {
        // If Slingshot is not in aimingMode, don't run this code
        if (!aimingMode) return;                                                  
                                                                                 
        Vector3 mousePos2D = Input.mousePosition;                                  
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        // Find the delta from the launchPos to the mousePos3D
        Vector3 mouseDelta = mousePos3D - launchPos;
        // Limit mouseDelta to the radius of the Slingshot SphereCollider          
        float maxMagnitude = this.GetComponent<CircleCollider2D>().radius;
        if (mouseDelta.magnitude > maxMagnitude)
        {
            mouseDelta.Normalize();
            mouseDelta *= maxMagnitude;
        }
        // Move the projectile to this new position
        Vector3 projPos = launchPos + mouseDelta;
        projectile.transform.position = projPos;
        if (Input.GetMouseButtonUp(0))
        {                                         
            // The mouse has been released
            aimingMode = false;
            projectileRigidbody.isKinematic = false;
            projectileRigidbody.velocity = -mouseDelta * velocityMult;
            projectile = null;
        }

    }

    void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");              
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
        launchPos = launchPointTrans.position;
    }
   

    void OnMouseEnter()
    {
        //print("Slingshot:OnMouseEnter()");
        launchPoint.SetActive(true);

    }
    void OnMouseExit()
    {
       // print("Slingshot:OnMouseExit()");
        launchPoint.SetActive(false);
    }

    void OnMouseDown()
    {                                                 
        // The player has pressed the mouse button while over Slingshot
        aimingMode = true;
        // Instantiate a Projectile
        projectile = Instantiate(prefabProjectile) as GameObject;
        // Start it at the launchPoint
        //projectile.transform.position = launchPos;
        // Set it to isKinematic for now
        projectile.GetComponent<Rigidbody>().isKinematic = true;
        projectileRigidbody = projectile.GetComponent<Rigidbody>();                // a
        projectileRigidbody.isKinematic = true;

    }


}
