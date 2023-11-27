using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public void LoadNivel1(){
        SceneManager.LoadScene("Level1");
    }

    public void LoadNivel2(){
        SceneManager.LoadScene("Nivel2");
    }

    public void Salir ()
    {
        //Salir del juego
        Application.Quit();
    }
}
