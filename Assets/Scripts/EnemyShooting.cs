using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyShooting : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletPos;
    private GameObject player;

    private GameObject boxPlant;

    private Animator anim;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
        boxPlant = GameObject.FindGameObjectWithTag("PlantWeakPoint");

        
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se o jogador está à esquerda da planta
        if (player.transform.position.x < transform.position.x)
        {
            float distance = Vector2.Distance(transform.position, player.transform.position);
            if (distance < 10)
            {
                timer += Time.deltaTime;
                if (timer > 3)
                {
                    timer = 0;
                    shoot();
                    Invoke("idleagainTrigger", 0.3f);
                }
            }
        }
    }

    void shoot(){
        anim.SetTrigger("Disparar");
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
        
    }

    private void idleagainTrigger(){
        anim.SetTrigger("idleAg");
    }

    public void morrer(Collision2D collision){
        anim.SetTrigger("morrer");
       Invoke("destruir_planta_2",0.3f);
        //Invoke(Destroy(collision.gameObject),03f);

    }

    private void destruir_planta(Collision2D collision){
        Destroy(collision.gameObject);
    }

    private void destruir_planta_2(){
        Destroy(boxPlant);
        Destroy(gameObject);
    }


}
