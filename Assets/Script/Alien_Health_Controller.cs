using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Alien_Health_Controller : MonoBehaviour
{
    public int Alien_HP;
    public GameObject Alien_Bullet;
    public Transform Alien_Cannon;
    public void Human_Victory()
    {
        SceneManager.LoadScene("Human_Victory_Scene");//make a victory screen for both
    }

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
                if (Alien_HP < 1)
                {
                    Human_Victory();
                }
            }
        }
    }
}
