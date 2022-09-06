using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    private float limiteInf;
    public Rigidbody2D pelota;
    public float fuerza;
    void Start()
    {
        
    }


    void Update()
    {
        limiteInf = transform.position.y;
        Debug.Log(limiteInf);
        if(limiteInf < -2.0)
        {
            pelota.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
        }
        
        
    }
}
