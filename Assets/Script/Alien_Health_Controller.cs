using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alien_Health_Controller : MonoBehaviour
{
    public int Alien_HP;
    public GameObject Alien_Bullet;
    public Transform Alien_Cannon;

    [SerializeField] private Image[] hearts;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Human_Bullet"))
        {
            Alien_HP -= 1;
            UpdateAlienHP();
            for (int i = 0; i < 5; i++)
            {
                Instantiate(Alien_Bullet, Alien_Cannon.position, Alien_Cannon.rotation);
            }
        }       
    }

    public void UpdateAlienHP()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Alien_HP)
            {
                hearts[i].color = Color.red;
            }
            else
            {
                hearts[i].color = Color.black;
            }
        }
    }
}
