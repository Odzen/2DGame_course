using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    //Singletone
    //Variable estatica, para acceder más facilmente, para no tenerlo linkeado en otros objetos
    public static Player obj;
    //Propiedades publicas
    public int lives = 3;
    public bool isGrounded = false;
    public bool isMoving = false;
    public bool isInmune = false;

    public float speed = 5f;
    public float jumpForce = 3f;
    public float movHor;

    public float inmuneTimeCnt = 0f;
    public float inmuneTime = 0.5f;

    //Obtener el escenario en un mismo layer
    public LayerMask groundLayer;

    //Para ver si colisiona
    public float radious = 0.3f;
    public float groundRayDist = 0.5f;

    //Propiedades privadas
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer spr;

    void Awake()
    {
        obj = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        //acceso a las propiedades del componente desde nuestro objeto
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movHor = Input.GetAxisRaw("Horizontal");
        isMoving = (movHor != 0);
        //Si nuestro personaje está tocando el piso
        isGrounded = Physics2D.CircleCast(transform.position, radious, Vector3.down, groundRayDist, groundLayer);

        //jump
        if (Input.GetKeyDown(KeyCode.Space))
            jump();

        //Cambiar animación de personaje dependiendo de para donde yo lo mueva
        flip(movHor); 
    }

    //Todo lo que tenga que ver con fisicas
    void FixedUpdate()
    {
        //Usar el rb que es el rigidbody con el input de movimiento horizontal, movHor
        //velocity acepta como entrada un Vector2: Conjunto de valores x e y
        rb.velocity = new Vector2(movHor * speed, rb.velocity.y);
    }

    public void jump()
    {
        //Si no esta tocando el piso, entonces retorna nada
        if (!isGrounded) return;

        //Agregar fuerza hacia arriba mediante su rigid body
        rb.velocity = Vector2.up * jumpForce;
    }
    
    //Para cambiar las animaciones dependiendo de la direccion en la que me muevo
    public void flip(float _xValue)
    {
        Vector3 theScale = transform.localScale;

        if (_xValue < 0)
            theScale.x = Mathf.Abs(theScale.x) * -1;
        else
        if (_xValue>0)
            theScale.x = Mathf.Abs(theScale.x);

        transform.localScale = theScale;
    }


    void OnDestroy()
    {
        obj = null;
    }
}
