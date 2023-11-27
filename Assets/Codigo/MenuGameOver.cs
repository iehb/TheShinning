using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MenuGameOver : MonoBehaviour
{
    [SerializeField] private GameObject menuGameOver;
    private DatosJugador datosJugador;

    private void Start(){
        datosJugador = GameObject.FindGameObjectWithTag("Player").GetComponent<DatosJugador>();
        datosJugador.MuerteJugador += ActivarMenu;
    }

    private void ActivarMenu(object sender, EventArgs e){
        menuGameOver.SetActive(true);
    }

    public void Reiniciar(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
      UnityEditor.EditorApplication.isPlaying=false;
      Application.Quit();  
    }
    
}
