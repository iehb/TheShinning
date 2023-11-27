using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DatoJugador : MonoBehaviour
{
    public int vidaPlayer;
    public Slider vidaVisual;
    public event EventHandler MuerteJugador;

    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;
        
        if(vidaPlayer <= 5 )
        {
            MuerteJugador?.Invoke(this, EventArgs.Empty);
            Destroy(gameObject);    
        }
    }
}
