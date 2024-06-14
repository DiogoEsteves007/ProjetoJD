using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanicoSound : MonoBehaviour
{

    [SerializeField] AudioSource fanico;
    private Collider2D col;

    private void Start()
    {
        col = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player")){
               fanico.Play();
                col.enabled = false; // Desativa o Collider2D

       }
    }    
}
