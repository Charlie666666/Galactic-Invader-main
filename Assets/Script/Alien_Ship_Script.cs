using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien_Ship_Script : MonoBehaviour
{

    public float Alien_speed = 5;

    private void Start()
    {

    }

    private void Update()
    {

        float Alien_h = Input.GetAxis("Alien_Horizontal");
        float Alien_v = Input.GetAxis("Alien_Vertical");

        Vector2 Alien_pos = transform.position;
        Alien_pos.x += Alien_h * Alien_speed * Time.deltaTime;
        Alien_pos.y += Alien_v * Alien_speed * Time.deltaTime;

        transform.position = Alien_pos;
    }

}