using UnityEngine;
using System.Collections;

public class Human_Cannon_Script : MonoBehaviour
{
    public GameObject Human_Bullet;
    public Transform Human_Cannon;

    void FixedUpdate ()
    {
        bool Human_shoot = Input.GetButtonDown("Human_Fire");

            if (Human_shoot) Instantiate(Human_Bullet, Human_Cannon.position, Human_Cannon.rotation);
    }
}