using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatoEnemigo : MonoBehaviour
{
    public int enemigo;
    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            Player.GetComponent<DatoJugador>().vidaPlayer -= enemigo;
        }
    }
}
