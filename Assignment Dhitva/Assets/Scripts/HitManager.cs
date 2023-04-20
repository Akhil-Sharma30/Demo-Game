using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitManager : MonoBehaviour
{
    public int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Cube"))
        {
            score += 10;
            Destroy(collision.gameObject); //to destroy the object which collided
            Debug.Log("hit the cube");
         
        }
        else if(collision.gameObject.CompareTag("Cylinder"))
        {
            score += 20;
            Destroy(collision.gameObject);
            Debug.Log("hit the cylinder");
        }
        else if(collision.gameObject.CompareTag("Sphere"))
        {
            score += 30;
            Destroy(collision.gameObject);
            Debug.Log("hit the sphere");
        }
    }


}
