using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{
    private float _vel;

  private Vector2 minPantalla;
  private Vector2 maxPantalla;
    // Start is called before the first frame update
    void Start()
    {
        _vel = 100;
        minPantalla= Camera.main.ViewportToWorldPoint(new Vector2(0,0));
        maxPantalla= Camera.main.ViewportToWorldPoint(new Vector2(1,1));

        minPantalla.x=minPantalla.x + 0.75f;
        maxPantalla.x=maxPantalla.x - 0.75f;
        minPantalla.y=minPantalla.y + 0.75f;
        maxPantalla.y=maxPantalla.y - 0.75f;
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

       nuevaPos.x=Mathf.Clamp(nuevaPos.x, minPantalla.x,maxPantalla.x );
       nuevaPos.y=Mathf.Clamp(nuevaPos.y, minPantalla.y,maxPantalla.y );
       transform.position=nuevaPos;
    }
}
