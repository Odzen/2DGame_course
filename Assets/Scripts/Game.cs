using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static Game obj;

    public int maxLives=3;

    public bool gamePaused=false;
    public int score=0;

    void Awake()
    {
        obj=this;
    }
    // Start is called before the first frame update
    void Start()
    {
        gamePaused=false;
        UIManajer.obj.startGame();
    }

    public void addScored(int scoreGive)
    {
        score+=scoreGive;
    }

    //reiniciar al escena actual
    public void gameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnDestroy()
    {
        obj=null;
    }
}
