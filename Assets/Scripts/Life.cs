using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int scoreGive=100;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Game.obj.addScored(scoreGive);
            Player.obj.addLive();
            gameObject.SetActive(false);
        }
    } 
}
