using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Ship_Script : MonoBehaviour
{

    public float Human_speed = 5;

    private void Start()
    {

    }

    private void Update()
    {

        float Human_h = Input.GetAxis("Human_Horizontal");
        float Human_v = Input.GetAxis("Human_Vertical");

        Vector2 Human_pos = transform.position;
        Human_pos.x += Human_h * Human_speed * Time.deltaTime;
        Human_pos.y += Human_v * Human_speed * Time.deltaTime;

        transform.position = Human_pos;
    }
     
}