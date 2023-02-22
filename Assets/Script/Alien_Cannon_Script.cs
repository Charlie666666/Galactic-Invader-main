using UnityEngine;
using System.Collections;

public class Alien_Cannon_Script : MonoBehaviour
{
    public GameObject Alien_Bullet;
    public Transform Alien_Cannon;

    void FixedUpdate()
    {
        bool Alien_shoot = Input.GetButtonDown("Alien_Fire");

        if (Alien_shoot) Instantiate(Alien_Bullet, Alien_Cannon.position, Alien_Cannon.rotation);
    }
}