using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObjeto : MonoBehaviour
{
   public bool destruirConCursor; 
    public bool destruirAutomatico;
    public LogicaPersonaje logicaPersonaje;

    public int tipo;
    
    
    // Start is called before the first frame update
    void Start()
    {
        logicaPersonaje= GameObject.FindGameObjectWithTag("Player").GetComponent<LogicaPersonaje>();
        Debug.Log("inicio");

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter (Collider other){
        Debug.Log("colisia");
        Efecto();
    }

    public void Efecto(){
      
       
       switch(tipo){
            case 1: 
                logicaPersonaje.gameObject.transform.localScale= new Vector3 (3,3,3);
            
                break;
            
            default:
                Debug.Log("Sin efecto");
                
                break; 
        }

    }
}
