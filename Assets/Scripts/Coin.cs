using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scoreGive=100;

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Game.obj.addScored(scoreGive);

            AudioManager.obj.playCoin();

            UIManajer.obj.updateScore();

            FxManager.obj.showPop(transform.position);
            gameObject.SetActive(false);

        }
    } 
}
