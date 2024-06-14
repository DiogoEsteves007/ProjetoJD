using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyStomp : MonoBehaviour
{
    private Animator anim;
    GameObject plantaObjeto;

    private void Start(){

       plantaObjeto = GameObject.FindWithTag("planta");
       //anim= plantaObjeto.GetComponent<Animator>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "PlantWeakPoint"){

            
            plantaObjeto.GetComponent<EnemyShooting>().morrer(collision);
            //nvoke(destruirPlanta(collision),0.4f);
            

           
            
        }
    }

}
