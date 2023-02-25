using UnityEngine;
using System.Collections;

public class Alien_Cannon_Script : MonoBehaviour
{
    public GameObject Alien_Bullet;
    public Transform Alien_Cannon;
    public AudioClip shootSound;

    void Update()
    {
        bool Alien_shoot = Input.GetButtonDown("Alien_Fire");

        if (Alien_shoot)
        {
            Instantiate(Alien_Bullet, Alien_Cannon.position, Alien_Cannon.rotation);

            if (shootSound != null)
            {
                AudioSource.PlayClipAtPoint(shootSound, transform.position, 1.0f);
            }
        }
    }
}
