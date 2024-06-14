using System.Collections;
using UnityEngine;

public class RandomSoundPlayer : MonoBehaviour
{
    [SerializeField] AudioSource ponto;
    private Collider2D col;

    private void Start()
    {
        col = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player")){
               ponto.Play();
                col.enabled = false; // Desativa o Collider2D

       }
    }   
}
