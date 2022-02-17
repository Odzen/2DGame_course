using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Variables

    private Rigidbody2D rb;

    public float movHor=0f;
    public float speed=3f;

    public bool isGroundFloor=true;
    public bool isGroundFront=false;

    public LayerMask groundLayer;
    public float frontGrndRayDist=0.25F;
    public float floorCheckY=0.52f;
    public float frontCheck=0.51f;
    public float frontDist=0.001f;

    public int scoreGive=50;

    public RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(movHor * speed, rb.velocity.y);
    }

    void getKilled()
    {
        gameObject.SetActive(false);
    }
}
