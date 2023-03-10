using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Human_Health_Controller : MonoBehaviour
{
    public int Human_HP;
    public GameObject Human_Bullet;
    public Transform Human_Cannon;
    public void Alien_Victory()
    {
        SceneManager.LoadScene("Alien_Victory_Scene");//Find a screen for this
    }

    [SerializeField] private Image[] hearts;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Alien_Bullet"))
        {
            Human_HP -= 1;
            UpdateHumanHP();
            for (int i = 0; i < 5; i++)
            {
                Instantiate(Human_Bullet, Human_Cannon.position, Human_Cannon.rotation);
            }
        }
    }

    public void UpdateHumanHP()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < Human_HP)
            {
                hearts[i].color = Color.red;
            }
            else
            {
                hearts[i].color = Color.black;
                if (Human_HP < 1)
                {
                    Alien_Victory();
                }
            }
        }
    }
}
