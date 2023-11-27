using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class SelectName : MonoBehaviour
{
   public TMP_InputField inputField;

   public TextMeshProUGUI textoNombre;

   public Image luz;

   public GameObject ButtonPlay;

   private void Awake(){

    luz.color= Color.red;

   }

   private void Update(){
    if(textoNombre.text.Length<4){
      luz.color= Color.red;
      ButtonPlay.SetActive(false);


    }

    if(textoNombre.text.Length>=4){
        luz.color= Color.green;
        ButtonPlay.SetActive(true);
    }
   }
   
   public void Aceptar(){
     PlayerPrefs.SetString("nombre",inputField.text);
     SceneManager.LoadScene(0);
   }
}
