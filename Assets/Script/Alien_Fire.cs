using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien_Fire : MonoBehaviour
{
    public float Alien_bulletForce = 750.0f;

    void OnTriggerEnter2D(Collider2D Alien_target)
    {
        if (Alien_target.gameObject.tag == "Alien_FirePoint") GetComponent<Rigidbody2D>().AddForce(transform.right * -1 * Alien_bulletForce);
       
    }
}