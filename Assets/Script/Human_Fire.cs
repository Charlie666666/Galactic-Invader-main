using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Fire : MonoBehaviour
{
    public float Human_bulletForce = 750.0f;

    void OnTriggerEnter2D (Collider2D Human_target)
    {
        if (Human_target.gameObject.tag == "Human_FirePoint") GetComponent<Rigidbody2D>().AddForce(transform.right * Human_bulletForce);
    }
}
