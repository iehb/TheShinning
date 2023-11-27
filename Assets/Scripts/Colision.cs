using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Colision : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag =="Player"){
            SceneManager.LoadScene(2);
        }
        
        
        //characterInQuicksand=true;
    }
}
