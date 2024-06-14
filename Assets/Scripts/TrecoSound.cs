using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrecoSound : MonoBehaviour
{
    
    [SerializeField] AudioSource treco;
    private Collider2D col;

    private void Start()
    {
        col = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player")){
               treco.Play();
                col.enabled = false; // Desativa o Collider2D

       }
    }   
}
