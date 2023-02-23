using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien_Damage_Controller : MonoBehaviour
{

    [SerializeField] private Alien_Health_Controller _Alien_healthController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Alien_Ship"))
        {
            Damage();
        }
    }

    void Damage()
    {
        _Alien_healthController.Alien_HP = _Alien_healthController.Alien_HP - 1;
        _Alien_healthController.UpdateAlienHP();
        gameObject.SetActive(false);
    }
}
