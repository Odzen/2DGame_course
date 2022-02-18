using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManajer : MonoBehaviour
{
    public static UIManajer obj;

    //Variables

    public Text scoreLbl;
    public Text livesLbl;

    public Transform UIPanel;


    void Awake()
    {
        obj=this;
    }

    public void updateLives()
    {
        livesLbl.text=""+Player.obj.lives;
    }

    public void updateScore()
    {
        scoreLbl.text=""+Game.obj.score;
    }

    public void startGame()
    {
        AudioManager.obj.playGui();

        Game.obj.gamePaused=true;
        UIPanel.gameObject.SetActive(true);
    }

    public void hideInitPanel()
    {
        AudioManager.obj.playGui();
        Game.obj.gamePaused=false;
        UIPanel.gameObject.SetActive(false);
    }

    void OnDestroy()
    {
        obj=null;
    }
}
