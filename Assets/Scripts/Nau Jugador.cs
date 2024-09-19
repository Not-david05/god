using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{
    private float _vel;

    // Start is called before the first frame update
    void Start()
    {
        _vel = 10;
    }

    // Update is called once per frame
    void Update()
    {
       float direccioIndicadaX = Input.GetAxisRaw("Horizontal");
       float direccioIndicadaY = Input.GetAxisRaw("Vertical");

       //Debug.Log("X: "+direccioIndicadaX+"Y: "+direccioIndicadaY);
       Vector2 direccionIndicada = new Vector2(direccioIndicadaX,direccioIndicadaY).normalized;
       Vector2 nuevaPos= transform.position;
       nuevaPos = nuevaPos + direccionIndicada * _vel * Time.deltaTime;
       transform.position=nuevaPos;
    }
}
