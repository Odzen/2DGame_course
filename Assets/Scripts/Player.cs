using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	//Propiedades publicas
    public int lives=3;
    public bool isGrounded=false;
    public bool isMooving=false;
    public bool isInmune=false;

    public float speed=5f;
    public float jumpForce=3f;
    public float movHor;

    public float inmuneTimeCnt=0f;
    public float inmuneTime=0.5f;

    //Obtener el escenario en un mismo layer
    public LayerMask groundLayer;
    
    //Para ver si colisiona
    public float radious=0.3f;
    public float groundRayDist=0.5f;

    //Propiedades privadas
    private Rigidbody2D rigidbody;
    private Animator anim;
    private SpriteRenderer spr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
