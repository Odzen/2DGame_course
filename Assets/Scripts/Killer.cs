using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Dañar Player si colisiona directamente
        if(collision.gameObject.CompareTag("Player"))
        {
            Game.obj.gameOver();
        }

    }
}
