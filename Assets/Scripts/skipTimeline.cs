// using System.Collections;
// using System.Collections.Generic;
// using Unity.PlasticSCM.Editor.WebApi;
// using UnityEngine;
// using UnityEngine.Playables;
// using UnityEngine.SceneManagement;

// public class skipTimeline : MonoBehaviour
// {
//     private int currentScene;
//     private bool timelinePlayed = false;

//     [SerializeField] private PlayableDirector playableDirector;
//     void Start()
//     {
//         Debug.Log(timelinePlayed);

//     }

    
//     private void OnTriggerEnter2D(Collider2D collider){
//         if(collider.CompareTag("Player") && !timelinePlayed){
//              playableDirector.Play();
//                 timelinePlayed = true;
                

//             GetComponent<BoxCollider2D>().enabled=false;
            
//         }
//     }

// }
