using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int bags = 0;
    [SerializeField] private Text BagsText;

    [SerializeField] AudioSource collectionSoundEffect;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bag50"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            bags= bags+50;
            BagsText.text = "Peso: "+bags; 
        }else if(collision.gameObject.CompareTag("Bag100"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            bags= bags+100;
            BagsText.text = "Peso: "+bags; 
        }else if(collision.gameObject.CompareTag("Bag150"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            bags= bags+150;
            BagsText.text = "Peso: "+bags; 
        }else if(collision.gameObject.CompareTag("Bag200"))
        {           
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            bags= bags+200;
            BagsText.text = "Peso: "+bags; 
        }else if(collision.gameObject.CompareTag("Bag250"))
        {           
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            bags= bags+250;
            BagsText.text = "Peso: "+bags; 
        }
    }   

}
