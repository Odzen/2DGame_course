using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform bg0;
    public float factor0=1f;

    public Transform bg1;
    public float factor1=1/2f;

    public Transform bg2;
    public float factor2=1/4f;

    private float displacement;
    private float iniCampPosFrame;
    private float nextCampPosFrame;
    

    // Update is called once per frame
    //Efecto parallax del fondo
    void Update()
    {   
        iniCampPosFrame=transform.position.x;
        transform.position=new Vector3(Player.obj.transform.position.x, transform.position.y,transform.position.z);
    }

    void LateUpdate()
    {
        nextCampPosFrame=transform.position.x;

        bg0.position=new Vector3(bg0.position.x + (nextCampPosFrame-iniCampPosFrame)*factor0,bg0.position.y,bg0.position.z);
        bg1.position=new Vector3(bg1.position.x + (nextCampPosFrame-iniCampPosFrame)*factor1,bg1.position.y,bg1.position.z);
        bg2.position=new Vector3(bg2.position.x + (nextCampPosFrame-iniCampPosFrame)*factor2,bg2.position.y,bg2.position.z);
    }
}
